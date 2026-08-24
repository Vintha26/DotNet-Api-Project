using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Model
{
    public class Supplier
    {
        [Key]
        public Guid SupplierId { get; set; } = Guid.NewGuid();
      
        public string SupplierName { get; set; } = string.Empty;
        public string? SupplierEmail { get; set; }
        public string? SupplierPhone { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierCity { get; set; }
        public string? SupplierPostalCode { get; set; }
        public string? SupplierCountry { get; set; }
        public ICollection<Product> Products { get; set; } =new List<Product>();
    }
}
