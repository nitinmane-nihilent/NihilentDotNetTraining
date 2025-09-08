
namespace Catalog
{
    public interface IProductRepository
    {
        void AddProduct(string name, decimal price);
        void RemoveProduct(int productId);
        string GetProduct(int productId);
    }
} 