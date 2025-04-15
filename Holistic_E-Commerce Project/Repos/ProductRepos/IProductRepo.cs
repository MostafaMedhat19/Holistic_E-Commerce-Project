using Holistic_E_Commerce_Project.Dtos.CustomerDtos;
using Holistic_E_Commerce_Project.Dtos.ProductDtos;

namespace Holistic_E_Commerce_Project.Repos.ProductRepos
{
    public interface IProductRepo
    {
        void AddProduct(ProductDtoRequest productDto);
       
    }
}
