using System;
using System.Collections.Generic;

// Enum to represent product categories
enum ProductCategory
{
    Electronics,
    Clothing,
    Books,
    Food
}

// Generic class to represent a product
class Product<T>
{
    public string Name { get; set; }
    public ProductCategory Category { get; set; }
    public T Details { get; set; }

    public Product(string name, ProductCategory category, T details)
    {
        Name = name;
        Category = category;
        Details = details;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Details: {Details}");
    }
}

// Specific class for electronics products
class ElectronicsDetails
{
    public string Brand { get; set; }
    public double Price { get; set; }

    public ElectronicsDetails(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Price: ${Price:F2}";
    }
}

// Specific class for clothing products
class ClothingDetails
{
    public string Size { get; set; }
    public string Material { get; set; }

    public ClothingDetails(string size, string material)
    {
        Size = size;
        Material = material;
    }

    public override string ToString()
    {
        return $"Size: {Size}, Material: {Material}";
    }
}

class Program
{
    static void Main()
    {
        // Create a list of products using generics
        List<Product<object>> inventory = new List<Product<object>>
        {
            new Product<object>("Laptop", ProductCategory.Electronics, new ElectronicsDetails("Dell", 899.99)),
            new Product<object>("T-Shirt", ProductCategory.Clothing, new ClothingDetails("Medium", "Cotton")),
            new Product<object>("Book", ProductCategory.Books, "Introduction to C# Programming"),
            new Product<object>("Apple", ProductCategory.Food, "Red Delicious")
        };

        // Display information about all the products in the inventory
        foreach (var product in inventory)
        {
            Console.WriteLine("----------");
            product.DisplayInfo();
            Console.WriteLine("----------");
        }
    }
}
