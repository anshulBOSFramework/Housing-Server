using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Housing_Server.DTOs;
using Housing_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Housing_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public UserController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserDetails(int id)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(h => h.Id == id);
            if (user == null)
            {
                return NotFound("Sorry, no user here :/");
            }
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(User_LoginDto request)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(h => h.Email == request.Email);

            if (user == null)
            {
                return BadRequest("User Not Found");
            }

            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Wrong Password");
            }

            string token = CreateToken(user);
            return Ok(token);
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User_RegisterDto request)
        {
            var search_user = await _context.Users
                .FirstOrDefaultAsync(h => h.Email == request.Email);
            
            if(search_user != null)
            {
                return BadRequest("User Email Already Exists");
            } else
            {
                CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

                var user = new User
                {
                    Name = request.Name,
                    Email = request.Email,
                    Phone = request.Phone,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    AccountCategory = request.AccountCategory
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return Ok(user);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(User_RegisterDto request)
        {
            var search_user = await _context.Users
                .FirstOrDefaultAsync(h => h.Email == request.Email);

            if (search_user == null)
            {
                return BadRequest("User Doesn't Exists");
            }
            else
            {
                CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

                search_user.Name = request.Name;
                search_user.Phone = request.Phone;
                search_user.PasswordHash = passwordHash;
                search_user.PasswordSalt = passwordSalt;

                await _context.SaveChangesAsync();

                return Ok(search_user);
            }
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                return computeHash.SequenceEqual(passwordHash);
            }
        }

    }
}
