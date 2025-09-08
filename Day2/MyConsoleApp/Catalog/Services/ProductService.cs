namespace Catalog;

public ProductService: IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void AddProduct(string name, decimal price)
    {
        _productRepository.AddProduct(name, price);
    }

    public void RemoveProduct(int productId)
    {
        _productRepository.RemoveProduct(productId);
    }

    public string GetProduct(int productId)
    {
        return _productRepository.GetProduct(productId);
    }
}