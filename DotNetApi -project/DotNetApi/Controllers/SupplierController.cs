using DotNetApi.Data;
using DotNetApi.Dto;
using DotNetApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase

    {
        private readonly AppDbContext _context;
        public SupplierController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _context.Suppliers.ToListAsync();
            return Ok(suppliers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierById(Guid id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound("Supplier not found.");
            }
            return Ok(supplier);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSupplier([FromBody] SupplierCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var supplier = new Supplier
            {
                SupplierName = dto.SupplierName,
                SupplierEmail = dto.SupplierEmail,
                SupplierPhone = dto.SupplierPhone,
                SupplierAddress = dto.SupplierAddress,
                SupplierCity = dto.SupplierCity,
                SupplierPostalCode = dto.SupplierPostalCode,
                SupplierCountry = dto.SupplierCountry
            };

            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSupplierById), new { id = supplier.SupplierId }, supplier);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSupplier(Guid id, [FromBody] SupplierUpdateDto dto)
        {
            var existing = await _context.Suppliers.FindAsync(id);
            if (existing == null)
                return NotFound("Supplier not found.");

            existing.SupplierName = dto.SupplierName;
            existing.SupplierEmail = dto.SupplierEmail;
            existing.SupplierPhone = dto.SupplierPhone;
            existing.SupplierAddress = dto.SupplierAddress;
            existing.SupplierCity = dto.SupplierCity;
            existing.SupplierPostalCode = dto.SupplierPostalCode;
            existing.SupplierCountry = dto.SupplierCountry;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SupplierExists(id))
                    return NotFound("Supplier not found.");
                throw;
            }

            return NoContent();
        }
        // Helper - not an API action
        private Task<bool> SupplierExists(Guid id)
        {
            return _context.Suppliers.AnyAsync(e => e.SupplierId == id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(Guid id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound("Supplier not found.");
            }

            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
