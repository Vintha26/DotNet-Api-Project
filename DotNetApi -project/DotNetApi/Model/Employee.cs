using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Model
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; } = Guid.NewGuid();
        public string EmployeeFirstName { get; set; } = string.Empty;
        public  string EmployeeLastName { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public string ? Notes { get; set; }
         public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
