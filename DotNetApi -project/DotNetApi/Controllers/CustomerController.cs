using DotNetApi.Data;
using DotNetApi.Dto;
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
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customer = new Customer
            {
                CustomerName = dto.CustomerName,
                CustomerEmail = dto.CustomerEmail,
                CustomerPhone = dto.CustomerPhone,
                CustomerAddress = dto.CustomerAddress,
                CustomerCity = dto.CustomerCity,
                CustomerPostalCode = dto.CustomerPostalCode,
                CustomerCountry = dto.CustomerCountry
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCustomerById),
                new { id = customer.CustomerId },
                new { customer.CustomerId, customer.CustomerName, customer.CustomerEmail }
            );
        }


        // PUT: api/Customer/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(Guid id,
            [FromBody] CustomerUpdateDto customerDto)
        {

            var existingCustomer = await _context.Customers.FindAsync(id);

            if (existingCustomer == null)
            {
                return NotFound("Customer not found.");
            }

            // Map allowed scalar fields from DTO to entity. This avoids model-binding
            // nested navigation properties (orders, etc.) that cause validation errors.
            existingCustomer.CustomerName = customerDto.CustomerName;
            existingCustomer.CustomerEmail = customerDto.CustomerEmail;
            existingCustomer.CustomerPhone = customerDto.CustomerPhone;
            existingCustomer.CustomerAddress = customerDto.CustomerAddress;
            existingCustomer.CustomerCity = customerDto.CustomerCity;
            existingCustomer.CustomerPostalCode = customerDto.CustomerPostalCode;
            existingCustomer.CustomerCountry = customerDto.CustomerCountry;

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