using System;
using System.Collections.Generic;

// Step 1: Define the Product class
public class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}

// Step 2: Define the Inventory class
public class Inventory
{
    private List<Product> products = new List<Product>();

    // Method to add a product
    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"Added {product.Name} with quantity {product.Quantity}");
    }

    // Method to remove a product
    public void RemoveProduct(string productName)
    {
        Product productToRemove = products.Find(p => p.Name == productName);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine($"Removed {productName}");
        }
        else
        {
            Console.WriteLine($"Product {productName} not found.");
        }
    }

    // Method to check for low inventory
    public void CheckLowInventory(int threshold)
    {
        Console.WriteLine("Low Inventory Products:");
        foreach (Product product in products)
        {
            if (product.Quantity < threshold)
            {
                Console.WriteLine($"{product.Name} has only {product.Quantity} left.");
            }
        }
    }
}

// Main method to test the Inventory class
class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        Product product1 = new Product("Laptop", 10);
        Product product2 = new Product("Mouse", 5);
        Product product3 = new Product("Keyboard", 2);

        inventory.AddProduct(product1);
        inventory.AddProduct(product2);
        inventory.AddProduct(product3);

        inventory.CheckLowInventory(3);
        inventory.RemoveProduct("Mouse");
    }
}
