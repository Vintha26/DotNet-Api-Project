namespace DotNetApi.Dto
{
    public class CategoryReadDto
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription { get; set; }
        public IEnumerable<Guid> ProductIds { get; set; } = new List<Guid>();
    }
}
