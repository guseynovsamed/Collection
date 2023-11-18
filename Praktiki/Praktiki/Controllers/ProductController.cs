using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Controllers
{
    public class ProductController
    {
        private IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        public void GetAll()
        {
            var result = _productService.GetAllProducts();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name+" "+item.Count+" "+item.Price);
            }
        }

        public void Search()
        {
            Console.WriteLine("Add search text");
            string text = Console.ReadLine();
            var res = _productService.SearchProduct(text);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name + " " + item.Count + " " + item.Price);
            }
        }
    }
}
