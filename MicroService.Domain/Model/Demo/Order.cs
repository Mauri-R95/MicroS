using MicroService.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MicroService.Domain.Demo
{
    public class Order : Entity, IAggregateRoot
    {
        private DateTime _orderDate;
        public Address _address { get; private set; }
        public string _buyerName { get; set; }
        public string _orderStatus { get; set; }
        public string _description { get; set; }
        public List<OrderItem> _orderItems { get; set; }


        public Order(int idOrder ,Address address, string buyerName, string orderStatus, string descripcion)
        {
             Id = idOrder;
            _address = address;
            _orderItems = new List<OrderItem>();
            _orderDate = DateTime.UtcNow;
            _buyerName = buyerName;
            _orderStatus = orderStatus;
            _description = descripcion;

        }

        public void AddItem(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }
    }
}
