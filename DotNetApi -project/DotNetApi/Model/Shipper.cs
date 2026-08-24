using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Model
{
    public class Shipper
    {
        [Key]
        public Guid ShipperId { get; set; } = Guid.NewGuid();
        public string ShipperName { get; set; } = string.Empty;
        public String? phone { get; set; }
         
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
