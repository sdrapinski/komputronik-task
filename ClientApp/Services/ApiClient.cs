using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ClientApp.Services
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7007/api/Warehouse/products/")
            };
        }

        // GET: /products
        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ProductDto>>(json)!;
        }
        // POST: /products
        public async Task AddProductAsync(ProductDto product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("", content);
            response.EnsureSuccessStatusCode();
        }
        // PUT: /products/{id}
        public async Task UpdateProductAsync(ProductDto product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{product.Id}", content);
            response.EnsureSuccessStatusCode();
        }
        // DELETE: /products/{id}
        public async Task DeleteProductAsync(long product_id)
        {
            var response = await _httpClient.DeleteAsync($"{product_id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
