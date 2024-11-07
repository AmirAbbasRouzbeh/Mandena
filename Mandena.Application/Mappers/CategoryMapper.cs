using Mandena.Application.DTOs.CategoriesDtos;
using Mandena.Domain.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandena.Application.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryDTO ToDTO(ProductCategory category)
        {
            if (category == null) return null;

            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
            };
        }

        public static ProductCategory ToEntity(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null) return null;

            return new ProductCategory
            {
                Id = categoryDTO.Id,
                Name = categoryDTO.Name,
                Description = categoryDTO.Description,
            };
        }
    }
}
