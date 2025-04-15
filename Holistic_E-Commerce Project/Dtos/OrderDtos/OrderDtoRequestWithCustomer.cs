using Holistic_E_Commerce_Project.Dtos.CustomerDtos;
using Holistic_E_Commerce_Project.Dtos.ProductDtos;
using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Dtos.OrderDtos
{
    public class OrderDtoRequestWithCustomer
    {
 
        public int Price { get; set; }

        public int CustomerId { get; set; }
    
        public IList<ProductDtoResponse> Products { get; set; }
    }
}
