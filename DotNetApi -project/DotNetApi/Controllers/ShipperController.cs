using DotNetApi.Data;
using DotNetApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ShipperController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetShippers()
        {
            var shippers = await _context.Shippers.ToListAsync();
            return Ok(shippers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShipperById(Guid id)
        {
            var shipper = await _context.Shippers.FindAsync(id);
            if (shipper == null)
            {
                return NotFound("Shipper not found.");
            }
            return Ok(shipper);
        }
        [HttpPost]
        public async Task<IActionResult> CreateShipper(Shipper shipper)
        {
            _context.Shippers.Add(shipper);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetShipperById), new { id = shipper.ShipperId }, shipper);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShipper(Guid id, [FromBody] Shipper shipper)
        {
            if (id != shipper.ShipperId)
            {
                return BadRequest("Shipper ID mismatch.");
            }

            _context.Entry(shipper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ShipperExists(id))
                {
                    return NotFound("Shipper not found.");
                }
                throw;
            }

            return NoContent();
        }
        // Helper - not an API action
        private Task<bool> ShipperExists(Guid id)
        {
            return _context.Shippers.AnyAsync(e => e.ShipperId == id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShipper(Guid id)
        {
            var shipper = await _context.Shippers.FindAsync(id);
            if (shipper == null)
            {
                return NotFound("Shipper not found.");
            }

            _context.Shippers.Remove(shipper);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
