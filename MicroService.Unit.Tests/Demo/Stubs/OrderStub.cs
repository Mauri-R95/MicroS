using MicroService.Domain.Demo;
using MicroService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Unit.Tests.Stubs
{
    public static class OrderStub
    {
        static Data data = new Data();
        public static List<Order> orders = data.getOrders();
        public static Order order = data.getOrder();
        public static OrderItem item = data.getItem();
        public static List<OrderItem> items = data.getItems();
    }
}
