using Holistic_E_Commerce_Project.Dtos.ProductDtos;
using Holistic_E_Commerce_Project.Repos.ProductRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Holistic_E_Commerce_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _productRepo;
        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] ProductDtoRequest productDto)
        {
            if (productDto == null)
            {
                return BadRequest("Product data is null");
            }
            _productRepo.AddProduct(productDto);
            return Ok("Product added successfully");
        }
    }
}
