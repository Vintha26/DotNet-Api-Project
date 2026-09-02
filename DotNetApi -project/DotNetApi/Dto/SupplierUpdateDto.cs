namespace DotNetApi.Dto
{
    public class SupplierUpdateDto
    {
        public string SupplierName { get; set; } = string.Empty;
        public string? SupplierEmail { get; set; }
        public string? SupplierPhone { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierCity { get; set; }
        public string? SupplierPostalCode { get; set; }
        public string? SupplierCountry { get; set; }
    }
}
