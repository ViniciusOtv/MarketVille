namespace MarktVille.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public CartItem(
            int productId,
            string name,
            int unitPrice)
        {
            this.ProductId = productId;
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Quantity = 0;
        }

        public decimal TotalPrice =>
        UnitPrice * Quantity;
    }
}