using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.iRepositories
{
    public interface IProductRepositories
    {
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);
        List<Product> GetProductFromDB();
    }
}
