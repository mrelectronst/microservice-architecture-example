using Customer.API.Models;
using Order.API.Infrastructure;
using Order.API.Models;
using Product.API.Models;
using System;

namespace Order.API.Service
{
    public class OrderService : IOrderService
    {
        public OrderDTO GetOrderById(int Id) => new OrderDTO
        {
            Id = 0,
            Amount = 1000,
            Quantity = 10,
            OrderDate = DateTime.Now,
            Customer = new CustomerDTO { Id = 0, FirstName = "Mehmet", LastName = "LAA" },
            Product = new ProductDTO { Id = 0, Name = "Kalem", Price = 20, Stock = 5 }
        };
    }
}
