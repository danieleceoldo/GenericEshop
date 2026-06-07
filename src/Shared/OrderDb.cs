using GenericEshop.Models;

namespace GenericEshop.Shared;

public class OrderDb
{
    public List<Cart> Data { get; set; } = new List<Cart>();
}