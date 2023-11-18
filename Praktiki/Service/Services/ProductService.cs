using Domain.Models;
using Service.Data;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            return AppDbContext.Products();
        }

        public List<Product> SearchProduct(string text)
        {
            return AppDbContext.Products().Where(n=>n.Name.Contains(text.ToLower().Trim().ToUpper())).ToList();
        }
    }
}
