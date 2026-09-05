using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

ProductService service = new ProductService();

Product product = new Product
{
    Id = 1,
    Name = "CBC Reagent",
    Code = "P001",
    Stock = 20
};

service.AddProduct(product);
Product product1 = new Product
{
    Id = 1,
    Name = "CBC Reagent",
    Code = "P002",
    Stock = 20
};

service.AddProduct(product);

List<Product> products = service.GetAllProducts();
Product? found = service.FindProductByCode("P001");

// service.RemoveProduct("P001");

// foreach (Product item in products)
// {
//     Console.WriteLine($"ID: {item.Id}");
//     Console.WriteLine($"Name: {item.Name}");
//     Console.WriteLine($"Stock: {item.Stock}");
//     Console.WriteLine($"Code: {item.Code}");
// }

if (found != null)
{
    Console.WriteLine($"ID: {found.Id}");
    Console.WriteLine($"Name: {found.Name}");
    Console.WriteLine($"Code: {found.Code}");
    Console.WriteLine($"Stock: {found.Stock}");
}

