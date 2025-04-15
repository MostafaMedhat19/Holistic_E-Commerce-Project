using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int Stock_Quantity { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
