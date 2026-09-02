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
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;
        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return Ok(orders);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetOrderById(Guid id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound("Order not found.");
            }
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var order = new Order
            {
                CustomerId = dto.CustomerId,
                EmployeeId = dto.EmployeeId,
                OrderDate = dto.OrderDate ?? DateTime.Now,
                ShipperId = dto.ShipperId
            };

            _context.Orders.Add(order);
            // If nested details provided, create them explicitly
            if (dto.OrderDetails != null)
            {
                foreach (var od in dto.OrderDetails)
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = order.OrderId,
                        ProductId = od.ProductId,
                        Quantity = od.Quantity
                    };
                    _context.OrderDetails.Add(orderDetail);
                }
            }

            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, order);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(Guid id, [FromBody] OrderUpdateDto dto)
        {
            var existing = await _context.Orders.FindAsync(id);
            if (existing == null)
                return NotFound("Order not found.");

            existing.CustomerId = dto.CustomerId;
            existing.EmployeeId = dto.EmployeeId;
            existing.OrderDate = dto.OrderDate ?? existing.OrderDate;
            existing.ShipperId = dto.ShipperId;

            // For simplicity, do not modify OrderDetails via this endpoint
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrderExists(id))
                    return NotFound("Order not found.");
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound("Order not found.");
            }
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private async Task<bool> OrderExists(Guid id)
        {
            return await _context.Orders.AnyAsync(o => o.OrderId == id);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAllOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            if (orders.Count == 0)
            {
                return NotFound("No orders found to delete.");
            }
            _context.Orders.RemoveRange(orders);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
