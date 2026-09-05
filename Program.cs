using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

ItemMasterService service = new ItemMasterService();

ItemMaster itemMaster = new ItemMaster
{
    Id = 1,
    Name = "CBC Reagent",
    Code = "P001",
    Department = "Biochemistry",
    Unit = "box",
    OpeningStock = 10,
    ReorderLevel = 4
};
service.AddProduct(itemMaster);
List<ItemMaster> itemMasters = service.GetAllItems();
// Product? found = service.FindProductByCode("P001");

foreach (ItemMaster item in itemMasters)
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

