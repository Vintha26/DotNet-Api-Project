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
    public class OrderDetailController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderDetailController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetOrderDetails()
        {
            var orderDetails = await _context.OrderDetails.ToListAsync();
            return Ok(orderDetails);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetOrderDetailById(Guid id)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail == null)
            {
                return NotFound("Order detail not found.");
            }
            return Ok(orderDetail);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail([FromBody] OrderDetailCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderDetail = new OrderDetail
            {
                OrderId = dto.OrderId,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity
            };

            _context.OrderDetails.Add(orderDetail);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOrderDetailById), new { id = orderDetail.OrderDetailsId }, orderDetail);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrderDetail(Guid id, [FromBody] OrderDetailUpdateDto dto)
        {
            var existing = await _context.OrderDetails.FindAsync(id);
            if (existing == null)
                return NotFound("Order detail not found.");

            existing.OrderId = dto.OrderId;
            existing.ProductId = dto.ProductId;
            existing.Quantity = dto.Quantity;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrderDetailExists(id))
                    return NotFound("Order detail not found.");
                throw;
            }

            return NoContent();
        }
        // Helper - not an API action
        private Task<bool> OrderDetailExists(Guid id)
        {
            return _context.OrderDetails.AnyAsync(e => e.OrderDetailsId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetail(Guid id)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail == null)
            {
                return NotFound("Order detail not found.");
            }

            _context.OrderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
