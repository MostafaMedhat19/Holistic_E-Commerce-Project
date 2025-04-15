using Holistic_E_Commerce_Project.Dtos.CustomerDtos;

namespace Holistic_E_Commerce_Project.Repos.CustomerRepos
{
    public interface ICustomerRepo
    {
      
        void AddCustomer(CustomerDtoRequest customerDto);
        CustomerDtoResponse GetCustomerById(int id);
       
    }
}
