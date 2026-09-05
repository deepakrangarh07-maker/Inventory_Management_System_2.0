using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

ProductService service = new ProductService();

Product product = new Product
{
    Id = 1,
    Name = "CBC Reagent",
    Code = "P001",
    Department = "Biochemistry",
    Unit = "box",
    OpeningStock = 10,
    ReorderLevel = 4
};
service.AddProduct(product);
List<Product> products = service.GetAllProduct();
// Product? found = service.FindProductByCode("P001");

foreach (Product item in products)
{
    Console.WriteLine($"ID: {item.Id}");
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"Code: {item.Code}");
    Console.WriteLine($"Department: {item.Department}");
    Console.WriteLine($"Unit: {item.Unit}");
    Console.WriteLine($"OpeningStock: {item.OpeningStock}");
    Console.WriteLine($"CurrentStock: {item.CurrentStock}");
    Console.WriteLine($"ReorderLevel: {item.ReorderLevel}");
}

// if (found != null)
// {
//     Console.WriteLine($"ID: {found.Id}");
//     Console.WriteLine($"Name: {found.Name}");
//     Console.WriteLine($"Code: {found.Code}");
//     Console.WriteLine($"Quantity: {found.Quantity}");
//     Console.WriteLine($"Department: {found.Department}");
//     Console.WriteLine($"Unit: {found.Unit}");
//     Console.WriteLine($"OpeningStock: {found.OpeningStock}");
//     Console.WriteLine($"ReorderLevel: {found.ReorderLevel}");
// }

