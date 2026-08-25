using DotNetApi.Data;
using DotNetApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        // Get all customers
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _context.Customers.ToListAsync();

            return Ok(customers);
        }


        // GET: api/Customer/{id}
        // Get customer by CustomerId
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound("Customer not found.");
            }

            return Ok(customer);
        }


        // POST: api/Customer
        // Create a new customer
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCustomerById),
                new { id = customer.CustomerId },
                customer
            );
        }


        // PUT: api/Customer/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(
            Guid id,
            Customer customer)
        {
            var existingCustomer =
                await _context.Customers.FindAsync(id);

            if (existingCustomer == null)
            {
                return NotFound("Customer not found.");
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerName))
            {
                existingCustomer.CustomerName = customer.CustomerName;
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerEmail))
            {
                existingCustomer.CustomerEmail = customer.CustomerEmail;
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerPhone))
            {
                existingCustomer.CustomerPhone = customer.CustomerPhone;
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerAddress))
            {
                existingCustomer.CustomerAddress = customer.CustomerAddress;
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerCity))
            {
                existingCustomer.CustomerCity = customer.CustomerCity;
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerPostalCode))
            {
                existingCustomer.CustomerPostalCode =
                    customer.CustomerPostalCode;
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerCountry))
            {
                existingCustomer.CustomerCountry =
                    customer.CustomerCountry;
            }

            await _context.SaveChangesAsync();

            return Ok(existingCustomer);
        }


        // DELETE: api/Customer/{id}
        // Delete customer
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            var customer =
                await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound("Customer not found.");
            }

            _context.Customers.Remove(customer);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}