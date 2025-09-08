using Catalog;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IProductRepository = new ProductRepository();
IProductService productService = new ProductService(productRepository);
List<Product> productList = new List<Product>()
[
    new Product { Id = 1, Name = "Laptop", Price = 999.99m },
    new Product { Id = 2, Name = "Smartphone", Price = 499.99m },
    new Product { Id = 3, Name = "Tablet", Price = 299.99m }
];

foreach (var product in productList)
{
   productService.AddProduct(product.Name, product.Price);
}


// List<string> productDetails = new List<string>
// {
//     productService.GetProduct(1),
//     productService.GetProduct(2)
// };