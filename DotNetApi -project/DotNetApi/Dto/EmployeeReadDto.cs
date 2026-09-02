namespace DotNetApi.Dto
{
    public class EmployeeReadDto
    {
        
        public Guid EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; } = string.Empty;
        public string EmployeeLastName { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public string? Notes { get; set; }
        public IEnumerable<Guid> OrderIds { get; set; } = new List<Guid>();
    
    }
}
