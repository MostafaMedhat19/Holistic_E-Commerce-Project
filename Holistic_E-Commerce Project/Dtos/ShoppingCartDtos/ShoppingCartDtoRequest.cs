using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Dtos.ShoppingCartDtos
{
    public class ShoppingCartDtoRequest
    {
        [Required]
        public int NumberOfitems { get; set; }
    }
}
