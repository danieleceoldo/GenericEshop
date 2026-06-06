using GenericEshop.Models;

namespace GenericEshop.Shared;

public class ProductDb
{
    public List<Product> Data { get; set; } = new List<Product>
    {
        new Product
        {
            Id="P001",
            Name="Product 1",
            Price=19.99m,
            Description="This is the first product.",
            ImageUrl="https://via.placeholder.com/150"
        },
        new Product
        {
            Id="P002",
            Name="Product 2",     
            Price = 29.99m,
            Description = "This is the second product.",
            ImageUrl = "https://via.placeholder.com/150"
        },
        new Product
        {
            Id = "P003",
            Name = "Product 3",
            Price = 39.99m,
            Description = "This is the third product.",
            ImageUrl = "https://via.placeholder.com/150"
        }
    };
}