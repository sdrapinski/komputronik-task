namespace WebApi.Models.DTO
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public long Category_Id { get; set; }

        public string CategoryName { get; set; } = string.Empty;
    }
}
