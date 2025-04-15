using Holistic_E_Commerce_Project.Dtos.CustomerDtos;
using Holistic_E_Commerce_Project.Dtos.ProductDtos;
using Holistic_E_Commerce_Project.Model;
using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Dtos.OrderDtos
{
    public class OrderDtoResponseWithCustomer
    {
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }

  
        public CustomerDtoResponseWithoutRelation Customer { get; set; }
        public IList<ProductDtoResponse> Products { get; set; }
    }
}
