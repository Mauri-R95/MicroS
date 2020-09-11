using MicroService.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.Domain.Demo
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> Get(int id);
        Task<IEnumerable<OrderItem>> GetAllItem();
        Task<OrderItem> GetItem(int id);
    }
}
