namespace DotNetApi.Dto
{
    public class CategoryUpdateDto
    {
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription { get; set; }
    }
}
