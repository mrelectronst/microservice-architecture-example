using Customer.API.Models;
using Product.API.Models;
using System;

namespace Order.API.Models
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public double Quantity { get; set; }

        public decimal Amount { get; set; }

        public DateTime? OrderDate { get; set; }

        public ProductDTO Product { get; set; }

        public CustomerDTO Customer { get; set; }

    }
}
