using Inventory_Management_System;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

ItemMasterService service = new ItemMasterService();

StockService stockService = new();

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
    stockService.StockIn(item, 6);
    Console.WriteLine($"After Stock In Current Stock: {item.CurrentStock}");    
    stockService.Stockout(item, 20);
    Console.WriteLine($"After Stock Out Current Stock: {item.CurrentStock}");
}

// service.UpdateItemName("CBC Reagent");

// foreach (ItemMaster item in itemMasters)
// {
//     Console.WriteLine($"ID: {item.Id}");
//     Console.WriteLine($"Name: {item.Name}");
//     Console.WriteLine($"Code: {item.Code}");
//     Console.WriteLine($"Department: {item.Department}");
//     Console.WriteLine($"Unit: {item.Unit}");
//     Console.WriteLine($"OpeningStock: {item.OpeningStock}");
//     Console.WriteLine($"CurrentStock: {item.CurrentStock}");
//     Console.WriteLine($"ReorderLevel: {item.ReorderLevel}");
    
// }



