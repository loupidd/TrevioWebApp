namespace TrevioWepApp.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ProductImageUrl { get; set; }

        public CartItem(int productId, string productName, decimal price, int quantity, string productImageUrl)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            ProductImageUrl = productImageUrl;
        }
    }
}
