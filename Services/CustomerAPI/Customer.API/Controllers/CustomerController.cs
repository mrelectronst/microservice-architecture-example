using Customer.API.Infrastructure;
using Customer.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpGet("{Id}")]
        public CustomerDTO GetCustomerById(int Id)
        {
            return _customerService.GetCustomerById(Id);
        }
        
    }
}
