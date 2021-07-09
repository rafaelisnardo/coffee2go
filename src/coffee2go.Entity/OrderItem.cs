namespace coffee2go.Entity
{
    public class OrderItem
    {
        public int orderId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public double unitPrice { get; set; }
    }
}