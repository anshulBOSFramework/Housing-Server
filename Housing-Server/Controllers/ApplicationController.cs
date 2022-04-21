using Housing_Server.DTOs.ApplicationDtos;
using Housing_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Housing_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly DataContext _context;

        public ApplicationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Application>>> GetPropertyApplications(int id)
        {
            var applications = await _context.Applications
                .Where(app => app.PropertyId == id)
                .ToListAsync();

            if (applications == null)
            {
                return NotFound("Sorry, no applications here :/");
            }

            return Ok(applications);
        }

        [HttpPost]
        public async Task<ActionResult<Application_BuyDto>> PostPropertyApplication(Application_BuyDto request)
        {
            if (request == null)
            {
                return NotFound("Sorry, no applications here :/");
            } else
            {
                var results = new Application
                {
                    PropertyId = request.PropertyId,
                    PropertyCategory = request.PropertyCategory,
                    PropertyService = request.PropertyService,
                    Name = request.Name,
                    PhoneNumber = request.PhoneNumber,
                    Email = request.Email,
                };
                _context.Applications.Add(results);
                await _context.SaveChangesAsync();
                return Ok(results);

            }
        }
    }
}
