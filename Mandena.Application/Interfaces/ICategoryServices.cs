using Mandena.Application.DTOs.CategoriesDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandena.Application.Interfaces
{
    public interface ICategoryServices
    {
        Task<List<CategoryDTO>> GetCategoryListAsync();
    }
}
