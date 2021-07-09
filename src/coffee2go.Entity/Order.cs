using System;
using System.Collections.Generic;

namespace coffee2go.Entity
{
    public class Order
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public int orderQuantity { get; set; }
        public double orderTotalPrice { get; set; }
        public DateTime orderDate { get; set; }
        public int paymentTransactionId { get; set; }
        public bool hasBeenShiped { get; set; }
        public List<OrderItem> orderItens { get; set; }
    }
}