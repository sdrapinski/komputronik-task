using ClientApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7007/api/Warehouse/")
            };
        }

        // GET: /products
        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("products");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ProductDto>>(json)!;
        }

        // POST: /products
        public async Task<bool> AddProductAsync(ProductDto product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("products", content);
            return response.IsSuccessStatusCode;
        }

        // PUT: /products/{id}
        public async Task<bool> UpdateProductAsync(ProductDto product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"products/{product.Id}", content);
            return response.IsSuccessStatusCode;
        }

        // DELETE: /products/{id}
        public async Task<bool> DeleteProductAsync(long productId)
        {
            var response = await _httpClient.DeleteAsync($"products/{productId}");
            return response.IsSuccessStatusCode;
        }

        // GET: /categories
        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var response = await _httpClient.GetAsync("categories");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<CategoryDto>>(json)!;
        }
    }
}
