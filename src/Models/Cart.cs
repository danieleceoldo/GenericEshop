namespace GenericEshop.Models
{
    public class Cart
    {
        // This class can be expanded to include properties and methods for managing the shopping cart.
        public List<CartItem> Items = new List<CartItem>();
        public void AddItem(Product product, uint quantity)
        {
            var existingItem = Items.FirstOrDefault(item => item.Product == product);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }
        public uint TotalItems => (uint)Items.Sum(item => item.Quantity);
        public decimal TotalPrice => Items.Sum(item => item.TotalPrice);
    }
}