using Holistic_E_Commerce_Project.Dtos.OrderDtos;
using Holistic_E_Commerce_Project.Dtos.ShoppingCartDtos;
using Holistic_E_Commerce_Project.Model;
using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Dtos.CustomerDtos
{
    public class CustomerDtoRequest
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Contact { get; set; }
        public ShoppingCartDtoRequest Shopping_Cart { get; set; }
        public IList<OrderDtoRequest> Orders { get; set; }
    }
}
