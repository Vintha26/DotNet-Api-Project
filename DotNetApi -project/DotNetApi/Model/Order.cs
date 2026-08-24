using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetApi.Model
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } = Guid.NewGuid();
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        [ForeignKey("Employees")]
        public Guid EmployeeId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [ForeignKey("Shipper")]
        public Guid ShipperId { get; set; }

        public Customer Customer { get; set; } = null!;

        public Employee Employee { get; set; } = null!;

        public Shipper Shipper { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
