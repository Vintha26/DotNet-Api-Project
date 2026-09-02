namespace DotNetApi.Dto
{
    public class OrderDetailReadDto
    {
        public Guid OrderDetailsId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
