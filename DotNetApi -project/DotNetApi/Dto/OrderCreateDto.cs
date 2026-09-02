using System;
using System.Collections.Generic;

namespace DotNetApi.Dto
{
    public class OrderCreateDto
    {
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public Guid ShipperId { get; set; }

        // Optional: create details together
        public IEnumerable<OrderDetailCreateDto>? OrderDetails { get; set; }
    }
}
