namespace DotNetApi.Dto
{
    public class OrderDetailUpdateDto
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
