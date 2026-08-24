using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Model
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; } = Guid.NewGuid();
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
