using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

ProductService service = new ProductService();

Product product = new Product
{
    Id = 1,
    Name = "CBC Reagent",
    Stock = 20
};

service.AddProduct(product);

List<Product> products = service.GetAllProducts();

foreach (Product item in products)
{
    Console.WriteLine($"ID: {item.Id}");
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"Stock: {item.Stock}");
}