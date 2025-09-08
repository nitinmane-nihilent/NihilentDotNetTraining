namespace Catalog;

public interface IProductService
{
    void AddProduct(string name, decimal price);
    void RemoveProduct(int productId);
    string GetProduct(int productId);
}