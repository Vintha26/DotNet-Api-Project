using DotNetApi.Data;
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
        public async Task<IActionResult> CreateSupplier(Supplier supplier)
        {
            
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSupplierById), new { id = supplier.SupplierId }, supplier);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSupplier(Guid id, [FromBody] Supplier supplier)
        {
            if (id != supplier.SupplierId)
            {
                return BadRequest("Supplier ID mismatch.");
            }

            _context.Entry(supplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SupplierExists(id))
                {
                    return NotFound("Supplier not found.");
                }
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
