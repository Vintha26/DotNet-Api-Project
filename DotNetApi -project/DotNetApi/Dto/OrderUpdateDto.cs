using System;
using System.Collections.Generic;

namespace DotNetApi.Dto
{
    public class OrderUpdateDto
    {
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public Guid ShipperId { get; set; }
        public IEnumerable<OrderDetailUpdateDto>? OrderDetails { get; set; }
    }
}
