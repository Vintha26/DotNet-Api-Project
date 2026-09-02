using System;
using System.Collections.Generic;

namespace DotNetApi.Dto
{
    public class OrderReadDto
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid ShipperId { get; set; }
        public IEnumerable<Guid> OrderDetailIds { get; set; } = new List<Guid>();
    }
}
