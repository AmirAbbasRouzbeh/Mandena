using Mandena.Application.DTOs.CategoriesDtos;
using Mandena.Application.DTOs.ProductDtos;
using Mandena.Application.Interfaces;
using Mandena.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mandena.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatrgoryController : ControllerBase
    {
        private readonly ICategoryServices _categotyServie;

        public CatrgoryController(ICategoryServices categotyServie)
        {
            _categotyServie = categotyServie;
        }
        [HttpGet]
        public async Task<List<CategoryDTO>> GetCategories()
        {
            List<CategoryDTO> categories = await _categotyServie.GetCategoryListAsync();
            return categories;
        }
    }
}
