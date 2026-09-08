using Inventory_Management_System;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

ItemMasterService service = new ItemMasterService();
ReportService reportService = new(service);

StockMovementService movementService = new();

StockService stockService = new(movementService);


List<ItemMaster> itemMasters = service.GetAllItems();


// Product? found = service.FindProductByCode("P001");

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
//     stockService.StockIn(item, 6, "A000012", "admin");
//     Console.WriteLine($"After Stock In Current Stock: {item.CurrentStock}");    
//     stockService.Stockout(item, 10, "1", "admin");
//     Console.WriteLine($"After Stock Out Current Stock: {item.CurrentStock}");
// }

// // service.UpdateItemName("CBC Reagent");

// // foreach (ItemMaster item in itemMasters)
// // {
// //     Console.WriteLine($"ID: {item.Id}");
// //     Console.WriteLine($"Name: {item.Name}");
// //     Console.WriteLine($"Code: {item.Code}");
// //     Console.WriteLine($"Department: {item.Department}");
// //     Console.WriteLine($"Unit: {item.Unit}");
// //     Console.WriteLine($"OpeningStock: {item.OpeningStock}");
// //     Console.WriteLine($"CurrentStock: {item.CurrentStock}");
// //     Console.WriteLine($"ReorderLevel: {item.ReorderLevel}");

// // }

// movementService.viewMovement();

// reportService.StockSummary();


// reportService.LowStockReport();



bool running = true;

while (running)
{
    Console.WriteLine("===== LAB INVENTORY SYSTEM =====");
    Console.WriteLine("1. Add Item");
    Console.WriteLine("2. View Items");
    Console.WriteLine("3. Search Item");
    Console.WriteLine("4. Update Item");
    Console.WriteLine("5. Remove Item");
    Console.WriteLine("6. Stock In");
    Console.WriteLine("7. Stock Out");
    Console.WriteLine("8. Stock History");
    Console.WriteLine("9. Stock Summary");
    Console.WriteLine("10. Low Stock Report");
    Console.WriteLine("0. Exit");

    Console.Write("Enter your choice: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
       case "0":
       running = false;
       Console.WriteLine("Exiting ......");
       break;

       case "1":
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

            break;
        case "3":
            List<ItemMaster> items = service.GetAllItems();

            foreach (ItemMaster item in items)
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Code: {item.Code}");
                Console.WriteLine($"Department: {item.Department}");
                Console.WriteLine($"Unit: {item.Unit}");
                Console.WriteLine($"Current Stock: {item.CurrentStock}");
                Console.WriteLine("----------------------------");
            }

            break;
        case "4":
            service.UpdateItemName("CBC Reagent");
            break;
        
        case "5":
            service.RemoveItem("CBC Reagent");
            break;   
    }
}

