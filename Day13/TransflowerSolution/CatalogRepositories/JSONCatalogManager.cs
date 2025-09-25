namespace CatalogRepositories;

using CatalogEntities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JSONCatalogManager
{
    // This class is intended to manage catalog data stored in JSON format.
    // Implementation details would include methods for reading from and writing to JSON files,
    // as well as converting between JSON data and Product objects.

    private static string GetJsonFilePath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "Data", "products.json");
    }

    public static IEnumerable<Product>? LoadProducts()
    {
        var json = File.ReadAllText(GetJsonFilePath());
        return JsonSerializer.Deserialize<IEnumerable<Product>>(json);
    }

    public static void SaveProducts(IEnumerable<Product> products)
    {
        var json = JsonSerializer.Serialize(products);
        File.WriteAllText(GetJsonFilePath(), json);
    }
}