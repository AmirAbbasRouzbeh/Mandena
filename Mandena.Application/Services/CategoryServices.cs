using Mandena.Application.DTOs.CategoriesDtos;
using Mandena.Application.DTOs.ProductDtos;
using Mandena.Application.Interfaces;
using Mandena.Application.Mappers;
using Mandena.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandena.Application.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly AppDbContext _context;

        public CategoryServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryDTO>> GetCategoryListAsync()
        {
            var categoryDB = await _context.ProductCategories.ToListAsync();
            List<CategoryDTO> categories = categoryDB.Select(CategoryMapper.ToDTO).ToList();
            return categories;
        }
    }
}
