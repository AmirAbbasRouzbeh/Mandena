using Mandena.Application.DTOs.CategoriesDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandena.Application.DTOs.ProductDtos
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
        public int CategoryId { get; set; }
    }
}
