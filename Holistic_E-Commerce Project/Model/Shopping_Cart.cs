using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Model
{
    public class Shopping_Cart
    {
        public int Shopping_CartId { get; set; }
        [Required]
        public int NumberOfitems { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
