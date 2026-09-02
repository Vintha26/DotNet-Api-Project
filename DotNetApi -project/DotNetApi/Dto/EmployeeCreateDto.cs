namespace DotNetApi.Dto
{
    public class EmployeeCreateDto
    {
        public string EmployeeFirstName { get; set; } = string.Empty;
        public string EmployeeLastName { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public string? Notes { get; set; }
    }
}
