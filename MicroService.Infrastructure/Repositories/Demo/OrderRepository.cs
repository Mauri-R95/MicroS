using MicroService.Domain.Demo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        Data data = new Data();
        private Order order;
        private OrderItem item;

        public async Task<Order> Get(int id)
        {
            var orders = data.getOrders();
            foreach(var e in orders)
            {
                if (id == e.Id) {
                    order = e;
                }
            }
            return await Task.FromResult(order);
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            var orders = data.getOrders();
            return await Task.FromResult(orders);
        }

        public async Task<IEnumerable<OrderItem>> GetAllItem()
        {
            var Items = data.getItems();
            return await Task.FromResult(Items);
        }

        public async Task<OrderItem> GetItem(int id)
        {
            var items = data.getItems();
            foreach (var e in items)
            {
                if (id == e.ProductId){
                    item = e;
                }
            }
            return await Task.FromResult(item);
        }
    }
}
