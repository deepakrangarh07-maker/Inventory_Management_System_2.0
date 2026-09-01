using Inventory_Management_System.Models;

namespace Inventory_Management_System.Services;

public class ProductService
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }
}