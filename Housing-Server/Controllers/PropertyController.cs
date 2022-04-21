using Housing_Server.DTOs.PropertyDtos;
using Housing_Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Housing_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly DataContext _context;

        public PropertyController(DataContext context)
        {
            _context = context;
        }

        // Fetch Info for user
        [HttpGet("{userID}"), Authorize]
        public async Task<ActionResult<Property_ResultDto>> FetchAllSellerListing(int userID)
        {
            var buys = await _context.PropertyBuys
                .Where(property => property.UserId == userID)
                .Include(property => property.Address)
                .ToListAsync();
            var rents = await _context.PropertyRents
                .Where(property => property.UserId == userID)
                .Include(property => property.Address)
                .ToListAsync();
            var pgs = await _context.PropertyPGs
                .Where(property => property.UserId == userID)
                .Include(property => property.Address)
                .ToListAsync();

            var result = new Property_ResultDto
            {
                BuyList = buys,
                RentList = rents,
                PGList = pgs
            };
            return Ok(result);
        }

        // Property Buy
        [HttpPost("buy"), Authorize]
        public async Task<ActionResult<PropertyBuy>> RegisterBuyProperty(PropertyBuy request)
        {
            _context.PropertyBuys.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpGet("buy/{id}"), Authorize]
        public async Task<ActionResult<PropertyBuy>> GetBuyPropertyDetails(int id)
        {
            var property = await _context.PropertyBuys
                .Include(property => property.Address)
                .FirstOrDefaultAsync(h => h.Id == id);

            if (property == null)
            {
                return NotFound("Sorry, no property here :/");
            }

            return Ok(property);
        }

        [HttpPut("buy"), Authorize]
        public async Task<ActionResult<PropertyBuy>> UpdateBuyerProperty (PropertyBuy request)
        {
            var property = await _context.PropertyBuys
                .Include(ad => ad.Address)
                .FirstOrDefaultAsync(h => h.Id == request.Id);

            if (property == null)
            {
                return NotFound("Sorry, no property found :/");
            }

            _context.PropertyBuys.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpDelete("buy/{id}"), Authorize]
        public async Task<ActionResult<JsonResult>> DeleteBuyProperty(int id)
        {
            var result = await _context.PropertyBuys
                .Include(ad => ad.Address)
                .FirstOrDefaultAsync(h => h.Id == id);

            if (result == null)
            {
                return NotFound("Sorry, no property found :/");
            }

            _context.PropertyBuys.Remove(result);

            await _context.SaveChangesAsync();

            return Ok();
        }

        // Property Rent 
        [HttpPost("rent"), Authorize]
        public async Task<ActionResult<PropertyRent>> RegisterRentProperty(PropertyRent request)
        {
            _context.PropertyRents.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpGet("rent/{id}"), Authorize]
        public async Task<ActionResult<PropertyRent>> GetRentPropertyDetails(int id)
        {
            var property = await _context.PropertyBuys
                .Include(property => property.Address)
                .FirstOrDefaultAsync(h => h.Id == id);

            if (property == null)
            {
                return NotFound("Sorry, no property here :/");
            }

            return Ok(property);
        }

        [HttpPut("rent"), Authorize]
        public async Task<ActionResult<PropertyRent>> UpdateRentProperty(PropertyRent request)
        {
            var property = await _context.PropertyRents
                .Include(ad => ad.Address)
                .FirstOrDefaultAsync(h => h.Id == request.Id);

            if (property == null)
            {
                return NotFound("Sorry, no property found :/");
            }

            _context.PropertyRents.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpDelete("rent/{id}"), Authorize]
        public async Task<ActionResult<JsonResult>> DeleteRentProperty(int id)
        {
            var result = await _context.PropertyRents
                .Include(ad => ad.Address)
                .FirstOrDefaultAsync(h => h.Id == id);

            if (result == null)
            {
                return NotFound("Sorry, no property found :/");
            }

            _context.PropertyRents.Remove(result);

            await _context.SaveChangesAsync();

            return Ok();
        }

        // Property PG/ Co-living 
        [HttpPost("pg-coliving"), Authorize]
        public async Task<ActionResult<PropertyPG>> RegisterPGProperty(PropertyPG request)
        {
            _context.PropertyPGs.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpGet("pg-coliving/{id}"), Authorize]
        public async Task<ActionResult<PropertyPG>> GetPGPropertyDetails(int id)
        {
            var property = await _context.PropertyPGs
                .Include(property => property.Address)
                .FirstOrDefaultAsync(h => h.Id == id);

            if (property == null)
            {
                return NotFound("Sorry, no property here :/");
            }

            return Ok(property);
        }

        [HttpPut("pg-coliving"), Authorize]
        public async Task<ActionResult<PropertyPG>> UpdatePGProperty(PropertyPG request)
        {
            var property = await _context.PropertyPGs
                .Include(ad => ad.Address)
                .FirstOrDefaultAsync(h => h.Id == request.Id);

            if (property == null)
            {
                return NotFound("Sorry, no property found :/");
            }

            _context.PropertyPGs.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpDelete("pg-coliving/{id}"), Authorize]
        public async Task<ActionResult<JsonResult>> DeletePGProperty(int id)
        {
            var result = await _context.PropertyPGs
                .Include(ad => ad.Address)
                .FirstOrDefaultAsync(h => h.Id == id);

            if (result == null)
            {
                return NotFound("Sorry, no property found :/");
            }

            _context.PropertyPGs.Remove(result);

            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
