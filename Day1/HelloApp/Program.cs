// HelloApp/Program.cs
// This is a simple C# console application that prints "Hello, World!" and demonstrates basic variable usage and conditional statements.
using Catalog; // Importing the Catalog namespace to use the Product class defined in Product.cs

Console.WriteLine("Hello, World!");
int counter = 100;
counter++;
Console.WriteLine(counter);

if(counter > 100)
{
    Console.WriteLine("Counter is greater than 100");
}
else
{
    Console.WriteLine("Counter is 100 or less");
}

Product prod = new Product(1, "Laptop", 999.99);
Console.WriteLine($"Product Details: Id={prod.Id}, Name={prod.Name}, Price={prod.Price}");//HelloApp/Product.cs
console.log($"Product Name: {prod.getName()}"); // Accessing the getName method of the Product class to print the product name