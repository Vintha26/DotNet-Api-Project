namespace DotNetApi.Dto
{
    public class CategoryCreateDto
    {
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription { get; set; }
    }
}
