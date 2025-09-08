namespace Catalog
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int nextId = 1;

        public void AddProduct(string name, decimal price)
        {
            var product = new Product { Id = nextId++, Name = name, Price = price };
            products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        public string GetProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            return product != null ? $"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}" : "Product not found";
        }
    }
}