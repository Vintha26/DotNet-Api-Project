namespace DotNetApi.Dto
{
    public class ProductCreateDto
    {
        public string? ProductName { get; set; }
        public string? Unit { get; set; }
        public decimal Price { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
