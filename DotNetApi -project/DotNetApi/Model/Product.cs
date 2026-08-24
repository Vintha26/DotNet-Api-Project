using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetApi.Model
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; } = Guid.NewGuid();
        public string? ProductName { get; set; }
        public string? Unit { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Supplier")]
        public Guid? SupplierId { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        //navigation properties

        public Supplier? Supplier { get; set; }
        public Category Category { get; set; } = null!;


        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
