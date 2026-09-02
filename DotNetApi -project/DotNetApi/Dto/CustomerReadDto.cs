namespace DotNetApi.Dto
{
    public class CustomerReadDto
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerPostalCode { get; set; }
        public string? CustomerCountry { get; set; }
        public IEnumerable<Guid> OrderIds { get; set; } = new List<Guid>();
    }
}
