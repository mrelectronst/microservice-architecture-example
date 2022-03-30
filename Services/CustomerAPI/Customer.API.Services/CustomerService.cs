using Customer.API.Infrastructure;
using Customer.API.Models;

namespace Customer.API.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerDTO GetCustomerById(int Id) => new CustomerDTO()
        {
            Id = 0,
            FirstName = "Ahmet",
            LastName = "KAR"
        };
    }
}
