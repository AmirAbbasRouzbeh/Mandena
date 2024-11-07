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
    public class ProductServices : IProductServices
    {
        private readonly AppDbContext _context;

        public ProductServices(AppDbContext context)
        {
            _context = context;
        }

        public Task<bool> CreateProductAsync(CreateProductDTO productDTO)
        {
            if (productDTO == null) return Task.FromResult(false);

            try
            {
                var product = ProductMapper.CreateToEntity(productDTO);
                _context.Products.AddAsync(product);
                _context.SaveChanges();
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
                throw;
            }
        }

        public async Task<List<ProductDTO>> GetProductsListAsync()
        {
            var ProductsDB = await _context.Products.Include(x=> x.ProductCategory).ToListAsync();
            List<ProductDTO> products = ProductsDB.Select(ProductMapper.ToDTO).ToList();
            return products;
        }
    }
}
