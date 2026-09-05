using Inventory_Management_System.Models;

namespace Inventory_Management_System.Services;

public class ProductService
{
    private List<Product> products = new List<Product>();
    public void AddProduct(Product product)
    {
        Product? existingProduct =  products.Find(existingProduct => existingProduct.Name == product.Name);
        if(existingProduct != null)
        {
            Console.WriteLine("Duplicate product found");
            return; 
        }

        // This Code Find the existing code value : 

        Product ? existingCode = products.Find(existingCode => existingCode.Code == product.Code);
       
        if(existingCode != null)
        {
            Console.WriteLine("Duplicate Code Found");
            return;
        }

        product.CurrentStock = product.OpeningStock;
        products.Add(product);

        Console.WriteLine("Product added successfully.");
    }
    // this code is print all the product into the program
    public List<Product> GetAllProduct()
    {
        return products;
    }
}

