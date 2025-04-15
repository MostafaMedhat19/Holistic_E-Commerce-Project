using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Dtos.ProductDtos
{
    public class ProductDtoResponse
    {
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int Stock_Quantity { get; set; }
    }
}
