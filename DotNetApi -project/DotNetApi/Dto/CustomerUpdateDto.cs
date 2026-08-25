namespace DotNetApi.Dto
{
    // DTO used for customer update requests to avoid binding navigation properties
    public class CustomerUpdateDto
    {
        public string CustomerName { get; set; } = string.Empty;
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerPostalCode { get; set; }
        public string? CustomerCountry { get; set; }
    }
}
