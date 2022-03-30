using Product.API.Infrastructure;
using Product.API.Models;
using System;

namespace Product.API.Service
{
    public class ProductService : IProductService
    {
        public ProductDTO GetProductById(int Id) => new ProductDTO
        {
            Id = 0,
            Name = "Kalem",
            Price = 10,
            Stock = 5
        };

    }
}
