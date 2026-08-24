using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetApi.Model
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailsId { get; set; } = Guid.NewGuid();
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        //Navigation properties

        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
