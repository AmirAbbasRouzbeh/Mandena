using Mandena.Application.DTOs.ProductDtos;
using Mandena.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandena.Application.Mappers
{
    public static class ProductMapper
    {
        public static ProductDTO ToDTO(Product product)
        {
            if (product == null) return null;

            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ProductType = product.ProductType,
                Category = CategoryMapper.ToDTO(product.ProductCategory),
            };
        }
        public static Product ToEntity(ProductDTO productDTO)
        {
            if (productDTO == null) return null;

            return new Product
            {
                Id = productDTO.Id,
                Name = productDTO.Name,
                Description = productDTO.Description,
                ProductType = productDTO.ProductType,
                ProductCategory = CategoryMapper.ToEntity(productDTO.Category) // استفاده از CategoryMapper
            };
        }
        public static Product CreateToEntity(CreateProductDTO productDTO)
        {
            if (productDTO == null) return null;

            return new Product
            {
                Id = Guid.NewGuid(),
                Name = productDTO.Name,
                Description = productDTO.Description,
                ProductType = productDTO.ProductType,
                ProductCategoryId = productDTO.CategoryId,
            };
        }
    }
}
