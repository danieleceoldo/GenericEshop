namespace GenericEshop.Models;

public class CartItem
{
    public Product? Product { get; set; }
    public uint Quantity { get; set; }
    public decimal TotalPrice => Product?.Price * Quantity ?? 0;
}