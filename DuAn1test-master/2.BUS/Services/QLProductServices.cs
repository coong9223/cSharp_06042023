using _1.DAL.Entities;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLProductServices : IQLProductServices
    {
        private IProductRepositories _iQLProduct;
        private IProducerRepositories _iQLProducer;
        private List<Product> _lstProduct;

        public QLProductServices()
        {
            _iQLProduct = new ProductRepositories();
            _lstProduct = new List<Product>();
            _iQLProducer = new ProducerRepositories();
        }
        public bool AddProduct(Product product)
        {
            _iQLProduct.AddProduct(product);
            return true;
        }

        public bool DeleteProduct(Product product)
        {
            _iQLProduct.DeleteProduct(product);
            return true;
        }

        public List<Product> GetProductFromDB()
        {
            _lstProduct = _iQLProduct.GetProductFromDB();
            return _lstProduct;
        }

        public bool UpdateProduct(Product product)
        {
            _iQLProduct.UpdateProduct(product);
            return true;
        }

        public List<ProductVm> ShowProduct()
        {
            //var data = _iQLProduct.GetProductFromDB().ToList();
            var data = (from a in _iQLProduct.GetProductFromDB()
                        join b in _iQLProducer.GetProducerFromDB() on a.ProducerID equals b.ID
                        select new ProductVm
                        {
                            Id = a.Id.ToString(),
                            Masp = a.MaSp,
                            Name = a.Name,
                            ProducerName = b.Name,
                            Price = a.Price,
                            OriginalPrice = a.OriginalPrice,
                            Stock = a.Stock,
                            DateCreated = a.DateCreated,
                            linkImage = a.LinkImage,
                            Note = a.Note,
                            Status = a.Status == true ? "Kinh doanh" : "Ngưng kinh doanh"
                        }).ToList();
            return data;
        }
    }
}
