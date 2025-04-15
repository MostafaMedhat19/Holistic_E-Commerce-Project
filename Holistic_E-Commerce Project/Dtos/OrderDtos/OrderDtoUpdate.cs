using Holistic_E_Commerce_Project.Dtos.ProductDtos;

namespace Holistic_E_Commerce_Project.Dtos.OrderDtos
{
    public class OrderDtoUpdate
    {
        public int Price { get; set; }
        public IList<ProductDtoUpdate> Products{ get; set; }
    }
} 
