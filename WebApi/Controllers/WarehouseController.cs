using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Data;
using WebApi.Models;
using WebApi.Models.DTO;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController(WarehouseDbContext context) : ControllerBase
    {
        private readonly WarehouseDbContext _context = context;

        //Get

        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var products = await _context.Product
            .Include(p => p.Category)
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Category_Id = p.Category_Id,
                Code = p.Code,
                Description = p.Description,
                CategoryName = p.Category!.Name
            })
            .ToListAsync();

            return Ok(products);
        }
        [HttpGet("products/{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await _context.Product.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
                return NotFound();

            var dto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryName = product.Category?.Name,
                Category_Id = product.Category_Id,
                Code = product.Code,
            };

            return Ok(dto);
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
        {
            var categories = await _context.Category
                .Select(c => new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();

            return Ok(categories);
        }

        //Post

        [HttpPost("products")]
        public async Task<ActionResult<ProductDto>> AddProduct(CreateProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price,
                Code = dto.Code,
                Description = dto.Description,
                Category_Id = dto.Category_Id
            };

            _context.Product.Add(product);
            await _context.SaveChangesAsync();

            var createdDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryName = (await _context.Category.FindAsync(product.Category_Id))?.Name
            };

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, createdDto);
        }

        //Put

        [HttpPut("products/{id}")]
        public async Task<IActionResult> UpdateProduct(int id, CreateProductDto dto)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
                return NotFound();

            product.Name = dto.Name;
            product.Price = dto.Price;
            product.Code = dto.Code;
            product.Description = dto.Description;
            product.Category_Id = dto.Category_Id;


            await _context.SaveChangesAsync();
            return NoContent();
        }

        //Delete

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
                return NotFound();

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
