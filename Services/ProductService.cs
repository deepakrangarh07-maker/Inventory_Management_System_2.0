using Inventory_Management_System.Models;

namespace Inventory_Management_System.Services;

public class ProductService
{
    private List<Product> products = new List<Product>();

    private Dictionary<string, Product> productLookup =
        new Dictionary<string, Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);

        productLookup.Add(product.Code, product);
    }


    public void RemoveProduct(string code)
    {
        if (productLookup.ContainsKey(code)){
            Product product = productLookup[code];
            products.Remove(product);
            productLookup.Remove(code);
        }
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

    public Product? FindProductByCode(string code)
    {
        if (productLookup.TryGetValue(code, out Product? product))
        {
            return product;
        }

        return null;
    }
}

