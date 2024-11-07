using Mandena.Application.DTOs.ProductDtos;
using Mandena.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mandena.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        [HttpGet]
        public async Task<List<ProductDTO>> GetProduct()
        {
            List<ProductDTO> products = await _productServices.GetProductsListAsync();
            return products;
        }

        [HttpPost]
        public Task<bool> AddProduct(CreateProductDTO product)
        {
            var addProductResult = _productServices.CreateProductAsync(product);
            return addProductResult;
        }
    }
}
