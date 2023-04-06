﻿using Asm_c4.Models;

namespace Asm_c4.iServices
{
    public interface iProduct
    {
        public bool createProduct(Product p);
        public bool updateProduct(Product p);
        public bool deleteProduct(Guid id);
        public List<Product> getAllProduct();
        public Product getById(Guid id);
        public List<Product> getByName(string name);
    }
}
