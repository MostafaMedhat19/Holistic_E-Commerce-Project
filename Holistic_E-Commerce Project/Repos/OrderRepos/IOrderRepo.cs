using Holistic_E_Commerce_Project.Dtos.OrderDtos;
using Holistic_E_Commerce_Project.Dtos.ProductDtos;

namespace Holistic_E_Commerce_Project.Repos.OrderRepos
{
    public interface IOrderRepo
    {
        public List<OrderDtoResponseWithCustomer> GetAllOrders();
        void AddOrder(OrderDtoRequestWithCustomer orderDto);
        bool  UpdateOrder(int id, OrderDtoUpdate orderDto);
        bool DeleteOrder(int id);

    }
}
