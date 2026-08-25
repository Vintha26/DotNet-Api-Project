using DotNetApi.Data;
using DotNetApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerOrdersController(AppDbContext context)
        {
            _context = context;
        }


        // GET: api/CustomerOrders/{customerId}
        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetCustomerOrders(
            Guid customerId)
        {
            var customer = await _context.Customers
                .Where(c => c.CustomerId == customerId)
                .Select(c => new
                {
                    CustomerId = c.CustomerId,

                    CustomerName = c.CustomerName,

                    Orders = c.Orders.Select(o => new
                    {
                        OrderId = o.OrderId,

                        OrderDate = o.OrderDate,

                        OrderDetails = o.OrderDetails.Select(od => new
                        {
                            OrderDetailId = od.OrderDetailsId,

                            ProductId = od.ProductId,

                            ProductName =
                                od.Product.ProductName,

                            Quantity = od.Quantity,

                            Price = od.Product.Price

                        }).ToList()

                    }).ToList()
                })
                .FirstOrDefaultAsync();


            if (customer == null)
            {
                return NotFound("Customer not found.");
            }


            return Ok(customer);
        }


        // DELETE: api/CustomerOrders/{customerId}
        [HttpDelete("{customerId}")]
        public async Task<IActionResult> DeleteCustomerOrders(Guid customerId)
        {
            var customer = await _context.Customers
                .Include(c => c.Orders)
                .ThenInclude(o => o.OrderDetails)
                .FirstOrDefaultAsync(c => c.CustomerId == customerId);

            if (customer == null)
            {
                return NotFound("Customer not found.");
            }

            if (!customer.Orders.Any())
            {
                return NotFound("No orders found for this customer.");
            }

            var orderDetails = customer.Orders
                .SelectMany(order => order.OrderDetails)
                .ToList();

            // Delete order details first
            _context.OrderDetails.RemoveRange(orderDetails);

            // Delete orders next
            _context.Orders.RemoveRange(customer.Orders);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    
    }
}