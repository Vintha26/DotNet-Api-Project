namespace DotNetApi.Dto
{
    public class ProductReadDto
    {
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Unit { get; set; }
        public decimal Price { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid CategoryId { get; set; }
        public IEnumerable<Guid> OrderDetailIds { get; set; } = new List<Guid>();
    }
}
