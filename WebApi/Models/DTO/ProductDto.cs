﻿namespace WebApi.Models.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;

        public string CategoryName { get; set; } = string.Empty;
    }
}
