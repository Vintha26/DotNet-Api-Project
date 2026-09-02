using System;

namespace DotNetApi.Dto
{
    public class ShipperUpdateDto
    {
        public string ShipperName { get; set; } = string.Empty;
        public string? Phone { get; set; }
    }
}
