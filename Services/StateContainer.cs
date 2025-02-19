using TrevioWepApp.Models; // Menambahkan referensi ke CartItem

namespace TrevioWepApp.Services
{
    public class StateContainer
    {
        private List<CartItem> _cartItems = new List<CartItem>();

        public List<CartItem> CartItems => _cartItems;

        public void AddToCart(Product product, int quantity)
        {
            // Cek apakah produk sudah ada dalam cart berdasarkan ProductId
            var existingItem = _cartItems.FirstOrDefault(x => x.ProductId == product.Id);
            if (existingItem != null)
            {
                // Jika ada, tambahkan jumlahnya
                existingItem.Quantity += quantity;
                existingItem.Price = existingItem.Quantity * product.Price;
            }
            else
            {
                // Jika belum ada, buat CartItem baru
                _cartItems.Add(new CartItem(product.Id, product.Name, product.Price, quantity, product.ImageUrl));
            }
        }

        public void RemoveFromCart(Product product)
        {
            // Hapus berdasarkan ProductId
            var itemToRemove = _cartItems.FirstOrDefault(x => x.ProductId == product.Id);
            if (itemToRemove != null)
            {
                _cartItems.Remove(itemToRemove);
            }
        }

        public void UpdateCartQuantity(Product product, int quantity)
        {
            var cartItem = _cartItems.FirstOrDefault(x => x.ProductId == product.Id);
            if (cartItem != null)
            {
                if (quantity > 0)
                {
                    cartItem.Quantity = quantity;
                    cartItem.Price = cartItem.Quantity * product.Price;
                }
                else
                {
                    RemoveFromCart(product); // Hapus item jika quantity 0
                }
            }
        }
    }
}