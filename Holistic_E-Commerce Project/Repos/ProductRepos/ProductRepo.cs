using Holistic_E_Commerce_Project.Data;
using Holistic_E_Commerce_Project.Dtos.ProductDtos;
using Holistic_E_Commerce_Project.Model;

namespace Holistic_E_Commerce_Project.Repos.ProductRepos
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;
        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddProduct(ProductDtoRequest productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Stock_Quantity = productDto.Stock_Quantity
            };
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
