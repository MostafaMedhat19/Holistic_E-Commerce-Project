using Holistic_E_Commerce_Project.Dtos.ProductDtos;
using Holistic_E_Commerce_Project.Model;

namespace Holistic_E_Commerce_Project.Dtos.OrderDtos
{
    public class OrderDtoResponse
    {
        public int Price { get; set; }
      
        public IList<ProductDtoResponse> Products { get; set; }
    }
}
