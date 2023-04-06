using _1.DAL.Context;
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private List<Product> _lstproducts;
        private DatabaseContext _context;
        public ProductRepositories()
        {
            _context = new DatabaseContext();
            _lstproducts = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteProduct(Product product)
        { 
            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }

        public List<Product> GetProductFromDB()
        {
            _lstproducts = _context.Products.ToList();
            return _lstproducts;
        }

        public bool UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return true;
        }
    }
}
