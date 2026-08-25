using System;
using System.Collections.Generic;

namespace DotNetApi.Dto
{
    public class CustomerOrdersDto
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public List<OrderDto> Orders { get; set; } = new List<OrderDto>();
    }
}
