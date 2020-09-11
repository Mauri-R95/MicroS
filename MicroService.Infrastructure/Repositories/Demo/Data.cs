using MicroService.Domain.Demo;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MicroService.Infrastructure
{
    public class Data
    {
        static Address address1 = new Address("Las Maravillas", 234, "Metropolitana", "Colina", 9340000);
        static Address address2 = new Address("Av Las Estrellas", 2, "Valparaiso", "Vina del Mar", 2580767);
        static Address address3 = new Address("Puerto Sidney", 65, "Metropolitana", "San Miguel", 8900000);

        OrderItem Item1 = new OrderItem(1, "Zapatos", 30000, 15, "a", 1);
        OrderItem Item2 = new OrderItem(2, "Pantalon", 15000, 5, "b", 2);
        OrderItem Item3 = new OrderItem(3, "Polera", 10000, 10, "c", 3);
        OrderItem Item4 = new OrderItem(4, "Chaqueta", 40000, 30, "d", 4);
        OrderItem Item5 = new OrderItem(5, "Gorro", 5000, 0, "e", 2);
        OrderItem Item6 = new OrderItem(6, "Calcetines", 7000, 5, "f", 1);
        Order order1 = new Order(1, address1, "Mauricio", "Pago Confirmado", "LLamar antes de llegar al domicilio");
        Order order2 = new Order(2, address2, "Pablo", "Pendiente de Entrega", "Entregar dia martes");
        Order order3 = new Order(3, address3, "Pamela", "Entregado", "Fin de semana");
        
        public Data()
        {
        
        }

        public List<Order> getOrders()
        {
            order1.AddItem(Item1);
            order1.AddItem(Item2);
            order1.AddItem(Item3);
            order2.AddItem(Item4);
            order2.AddItem(Item5);
            order3.AddItem(Item6);
            List<Order> orders = new List<Order> { order1, order2, order3 };
            return orders;
        }
        public List<OrderItem> getItems()
        {
            List<OrderItem> items = new List<OrderItem> { Item1, Item2, Item3, Item4, Item5 };
            return items;
        }

    }
}
