using Holistic_E_Commerce_Project.Data;
using Holistic_E_Commerce_Project.Dtos.OrderDtos;
using Holistic_E_Commerce_Project.Dtos.ProductDtos;
using Holistic_E_Commerce_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Holistic_E_Commerce_Project.Repos.OrderRepos
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _context;
        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddOrder(OrderDtoRequestWithCustomer orderDto)
        {
            var order = new Order
            {
                Price = orderDto.Price,
                CustomerId = orderDto.CustomerId,
                Products = orderDto.Products.Select(p => new Product
                {
                   
                    Name = p.Name,
                    Description = p.Description,
                    Stock_Quantity = p.Stock_Quantity
                }).ToList()
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public bool DeleteOrder(int id)
        {
           var order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return false;
            }
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return true;
        }

        public List<OrderDtoResponseWithCustomer> GetAllOrders()
        {
            var orderDto = _context.Orders.Include(o=> o.Products).Include(o => o.Customer);
            var orders = orderDto.Select(o => new OrderDtoResponseWithCustomer
            {
                Id = o.Id,
                Price = o.Price,
                Customer = new Dtos.CustomerDtos.CustomerDtoResponseWithoutRelation
                {
                    Name = o.Customer.Name,
                    Email = o.Customer.Email,
                    Contact = o.Customer.Contact
                },
                Products = o.Products.Select(p => new ProductDtoResponse
                {
                    Name = p.Name,
                    Description = p.Description,
                    Stock_Quantity = p.Stock_Quantity
                }).ToList()
            }).ToList();
            var orderss = _context.Orders
                .Select(o => new OrderDtoResponseWithCustomer
                {
                    Id = o.Id,
                    Price = o.Price,
                 
                    Products = o.Products.Select(p => new ProductDtoResponse
                    {
                  
                        Name = p.Name,
                        Description = p.Description,
                        Stock_Quantity = p.Stock_Quantity
                    }).ToList()
                }).ToList();
            return orders;
        }

        public bool UpdateOrder(int id, OrderDtoUpdate orderDto)
        {
           var order = _context.Orders.FirstOrDefault(o => o.Id == id);
           
            if (order == null)
            {
                return false;
            }
            var productsUpdate = _context.Products.FirstOrDefault(p => p.ProductId == orderDto.Products.FirstOrDefault().ProductId);
            productsUpdate.Name = orderDto.Products.FirstOrDefault().Name;
            productsUpdate.Description = orderDto.Products.FirstOrDefault().Description;
            productsUpdate.Stock_Quantity = orderDto.Products.FirstOrDefault().Stock_Quantity;
          
            order.Price = orderDto.Price;
         
          
          
           
            
            _context.Products.Update(productsUpdate);
            _context.Orders.Update(order);
            _context.SaveChanges();
            return true;
        }
    }
}
