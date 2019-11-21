﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int CustomerType { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
