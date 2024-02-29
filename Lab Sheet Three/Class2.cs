using System;

public class Product
{
    // Fields
    private int productId;
    private string productName;
    private double price;
    private int quantityInStock;

    // Constructor
    public Product(int productId, string productName, double price, int quantityInStock)
    {
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.quantityInStock = quantityInStock;
    }

    // Method to add product to the inventory
    public void AddProduct(int quantity)
    {
        quantityInStock += quantity;
        Console.WriteLine($"{quantity} {productName}(s) added to inventory. New quantity in stock: {quantityInStock}");
    }

    // Method to buy product from the inventory
    public void BuyProduct(int quantity)
    {
        if (quantity > quantityInStock)
        {
            Console.WriteLine("Insufficient quantity in stock.");
            return;
        }

        quantityInStock -= quantity;
        Console.WriteLine($"{quantity} {productName}(s) bought. Remaining quantity in stock: {quantityInStock}");
    }

    // Method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product ID: {productId}");
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Quantity in Stock: {quantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Product
        Product laptop = new Product(101, "Laptop", 800, 10);

        // Access and display product details
        laptop.DisplayProductDetails();

        // Attempt to modify the product's ID from external code
        // This will result in a compilation error because productId is private
        // laptop.productId = 102; // Uncommenting this line will result in a compilation error
    }
}