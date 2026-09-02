using System;
using System.Collections.Generic;

namespace DotNetApi.Dto
{
    public class ShipperReadDto
    {
        public Guid ShipperId { get; set; }
        public string ShipperName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public IEnumerable<Guid> OrderIds { get; set; } = new List<Guid>();
    }
}
