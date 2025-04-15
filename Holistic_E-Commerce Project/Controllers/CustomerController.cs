using Holistic_E_Commerce_Project.Dtos.CustomerDtos;
using Holistic_E_Commerce_Project.Repos.CustomerRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Holistic_E_Commerce_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] CustomerDtoRequest customerDto)
        {
            if (customerDto == null)
            {
                return BadRequest("Customer data is null");
            }
            _customerRepo.AddCustomer(customerDto);
            return Ok("Customer added successfully");
        }
        [HttpGet("GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _customerRepo.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            return Ok(customer);
        }
    }
}
