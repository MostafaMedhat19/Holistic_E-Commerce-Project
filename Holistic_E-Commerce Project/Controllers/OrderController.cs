using Holistic_E_Commerce_Project.Dtos.OrderDtos;
using Holistic_E_Commerce_Project.Repos.OrderRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Holistic_E_Commerce_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _orderRepo;
        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orders = _orderRepo.GetAllOrders();
            return Ok(orders);
        }
        [HttpPost]
        public IActionResult AddOrders([FromBody]  OrderDtoRequestWithCustomer orderDto)
        {
            if (orderDto == null)
            {
                return BadRequest("Order data is null");
            }
            _orderRepo.AddOrder(orderDto);
            return Created();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, [FromBody] OrderDtoUpdate orderDto)
        {
            if (orderDto == null)
            {
                return BadRequest("Order data is null");
            }
            var result = _orderRepo.UpdateOrder(id, orderDto);
            if (!result)
            {
                return NotFound("Order not found");
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
         public IActionResult DeleteOrder(int id)
        {

            if (id <= 0)
            {
                return BadRequest("Invalid order ID");
            }
            var result = _orderRepo.DeleteOrder(id);
            if (!result)
            {
                return NotFound("Order not found");
            }
            return NoContent();
        }
    }
}
