using Order.API.Models;

namespace Order.API.Infrastructure
{
    public interface IOrderService
    {
        public OrderDTO GetOrderById(int Id);
    }
}
