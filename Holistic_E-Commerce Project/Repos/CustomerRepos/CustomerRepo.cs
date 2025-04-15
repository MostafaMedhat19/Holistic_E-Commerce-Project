using Holistic_E_Commerce_Project.Data;
using Holistic_E_Commerce_Project.Dtos.CustomerDtos;
using Holistic_E_Commerce_Project.Dtos.OrderDtos;
using Holistic_E_Commerce_Project.Dtos.ProductDtos;
using Holistic_E_Commerce_Project.Dtos.ShoppingCartDtos;
using Holistic_E_Commerce_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Holistic_E_Commerce_Project.Repos.CustomerRepos
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(CustomerDtoRequest customerDto)
        {
           var customer = new Customer
           {
               Name = customerDto.Name,
               Email = customerDto.Email,
               Contact = customerDto.Contact,
               Shopping_Cart = new Shopping_Cart
               {
                   NumberOfitems = customerDto.Shopping_Cart.NumberOfitems,
               },
               Orders = customerDto.Orders.Select(o => new Order
               {
                   Price = o.Price,
                
               }).ToList()
           };
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public CustomerDtoResponse GetCustomerById(int id)
        {
            var customer = _context.Customers
                .Include(o => o.Orders)
                    .ThenInclude(p => p.Products)
                .Include(c => c.Shopping_Cart) // Make sure Shopping_Cart is included
                .FirstOrDefault(x => x.CustomerId == id);

            if (customer == null)
            {
                return null;
            }

            var customerDto = new CustomerDtoResponse
            {
                Name = customer.Name,
                Email = customer.Email,
                Contact = customer.Contact,
                Shopping_Cart = new ShoppingCartDtoResponse
                {
                    NumberOfitems = customer.Shopping_Cart?.NumberOfitems ?? 0
                },
                Orders = customer.Orders.Select(o => new OrderDtoResponse
                {
                    Price = o.Price,
                    Products = o.Products.Select(p => new ProductDtoResponse
                    {
                        Name = p.Name,
                        Description = p.Description,
                        Stock_Quantity = p.Stock_Quantity
                    }).ToList()
                }).ToList()
            };

            return customerDto;
        }

    }
}
