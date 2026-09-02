namespace DotNetApi.Dto
{
    public class OrderDetailCreateDto
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
