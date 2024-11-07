using Mandena.Application.DTOs.ProductDtos;
using System.Net.Http.Json;

namespace Mandena.AdminDashboard.Helper.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<ProductDTO>>("Product"); // URL API برای دریافت محصولات
        }

        public async Task<bool> CreateProduct(CreateProductDTO product)
        {
            var response = await _httpClient.PostAsJsonAsync("Product", product); // URL API برای ایجاد محصول
            return response.IsSuccessStatusCode;
        }
    }
}
