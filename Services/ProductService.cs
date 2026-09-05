using Inventory_Management_System.Models;

namespace Inventory_Management_System.Services;

public class ProductService
{
    private List<Product> products = new List<Product>();

    private Dictionary<string, Product> productLookup =
        new Dictionary<string, Product>();

    private HashSet<string> productName = new HashSet<string>();

    public void AddProduct(Product product)
    {

        if (productName.Contains(product.Name))
        {
            Console.WriteLine("Product Name is already exist");
            return;
        }
        products.Add(product);
        productName.Add(product.Name);
        productLookup.Add(product.Code, product);
        Console.WriteLine("Product added successfully.");

    }


    public void RemoveProduct(string code)
    {
        if (productLookup.ContainsKey(code)){
            Product product = productLookup[code];
            products.Remove(product);
            productName.Remove(product.Name);
            productLookup.Remove(code);
            Console.WriteLine("Product Removed Succesfully");
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

