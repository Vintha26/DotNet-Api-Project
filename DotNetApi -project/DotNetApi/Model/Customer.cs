using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Model
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; }= string.Empty;
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; } 
        public string? CustomerAddress { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerPostalCode { get; set; }
        public string? CustomerCountry { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
        
    
}
