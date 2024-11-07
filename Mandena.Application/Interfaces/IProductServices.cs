using Mandena.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandena.Application.Interfaces
{
    public interface IProductServices
    {
        Task<List<ProductDTO>> GetProductsListAsync();
        Task<bool> CreateProductAsync(CreateProductDTO productDTO);

    }
}
