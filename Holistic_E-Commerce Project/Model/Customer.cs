using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Contact { get; set; }
        public Shopping_Cart Shopping_Cart { get; set; }
        public IList<Order> Orders { get; set; }

    }
}
