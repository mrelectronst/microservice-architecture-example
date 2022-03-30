using Customer.API.Models;

namespace Customer.API.Infrastructure
{
    public interface ICustomerService
    {
        public CustomerDTO GetCustomerById(int Id);
    }
}
