using Holistic_E_Commerce_Project.Dtos.OrderDtos;
using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Model
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
       
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public IList<Product> Products { get; set; }

        internal object Select(Func<object, OrderDtoResponse> value)
        {
            throw new NotImplementedException();
        }
    }
}
