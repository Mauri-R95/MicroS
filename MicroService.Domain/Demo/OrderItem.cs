using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Domain.Demo
{
    public class OrderItem
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public float Discount { get; set; }
        public string PictureUrl { get; set; }
        public int Units { get; set; }
        public OrderItem(int productId, string productName, float unitPrice, float discount, string pictureUrl, int units)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Discount = discount;
            PictureUrl = pictureUrl;
            Units = units;
        }

    }
}
