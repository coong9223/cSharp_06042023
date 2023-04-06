using Asm_c4.Models;
using Asm_c4.iServices;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
//using NuGet.Protocol.Core.Types;

namespace Asm_c4.Services
{
    public class ProductSer : iProduct
    {
        AsmDbContext dbContext;
        public ProductSer()
        {
            dbContext = new AsmDbContext();
        }
        public bool createProduct(Product p)
        {
            try
            {
                dbContext.Products.Add(p);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProduct(Guid id)
        {
            try
            {
                var pro = dbContext.Products.Find(id);
                dbContext.Products.Remove(pro);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> getAllProduct()
        {
            return dbContext.Products.ToList();
        }

        public Product getById(Guid id)
        {
            return dbContext.Products.FirstOrDefault(v => v.idProduct == id);
        }

        public List<Product> getByName(string name)
        {
            return dbContext.Products.Where(v => v.nameProduct.Contains(name)).ToList();
        }

        public bool updateProduct(Product p)
        {
            try
            {
                var pro = dbContext.Products.Find(p.idProduct);
                pro.nameProduct = p.nameProduct;
                pro.priceProduct = p.priceProduct;
                pro.availableQuantity = p.availableQuantity;
                pro.statusProduct = p.statusProduct;
                pro.supplier = p.supplier;
                pro.description = p.description;
                pro.LinkAnh = p.LinkAnh;
                dbContext.Products.Update(pro);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
