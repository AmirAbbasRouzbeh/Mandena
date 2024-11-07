using Mandena.Application.DTOs.CategoriesDtos;
using Mandena.Application.DTOs.ProductDtos;
using System.Net.Http.Json;

namespace Mandena.AdminDashboard.Helper.Services
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryDTO>> GetCategories()
        {
            return await _httpClient.GetFromJsonAsync<List<CategoryDTO>>("Catrgory"); // URL API برای دریافت محصولات
        }
    }
}
