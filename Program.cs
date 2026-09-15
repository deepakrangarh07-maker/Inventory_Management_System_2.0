using Inventory_Management_System;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;
using LabInventorySystem.Enums;


// ========================================
// CREATE SERVICES
// ========================================

ItemMasterService service = new ItemMasterService();

ReportService reportService = new ReportService(service);

StockMovementService movementService = new StockMovementService();

StockService stockService = new StockService(movementService);


// ========================================
// MAIN MENU
// ========================================

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("=================================");
    Console.WriteLine("      LAB INVENTORY SYSTEM");
    Console.WriteLine("=================================");

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


    // ========================================
    // MENU SWITCH
    // ========================================

    switch (choice)
    {

        // ====================================
        // 0. EXIT
        // ====================================

        case "0":

            running = false;

            Console.WriteLine("Exiting ......");

            break;


        // ====================================
        // 1. ADD ITEM
        // ====================================

        case "1":

            ItemMaster itemMaster = new ItemMaster
            {
                Id = 1,
                Name = "CBC Reagent",
                Code = "P001",
                Department = Department.Biochemistry,
                Unit = "box",
                OpeningStock = 10,
                ReorderLevel = 4
            };

            service.AddProduct(itemMaster);

            break;


        // ====================================
        // 2. VIEW ITEMS
        // ====================================

        case "2":

            List<ItemMaster> items = service.GetAllItems();

            if (items.Count == 0)
            {
                Console.WriteLine("No items found.");
                break;
            }

            foreach (ItemMaster item in items)
            {
                Console.WriteLine();
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Code: {item.Code}");
                Console.WriteLine($"Department: {item.Department}");
                Console.WriteLine($"Unit: {item.Unit}");
                Console.WriteLine($"Opening Stock: {item.OpeningStock}");
                Console.WriteLine($"Current Stock: {item.CurrentStock}");
                Console.WriteLine($"Reorder Level: {item.ReorderLevel}");
                Console.WriteLine("----------------------------");
            }

            break;


        // ====================================
        // 3. SEARCH ITEM
        // ====================================

        case "3":

            Console.Write("Enter item name to search: ");

            string? searchName = Console.ReadLine();

            if (searchName == null)
            {
                Console.WriteLine("Item name is required.");
                break;
            }

            ItemMaster? searchItem =
                service.SearchItemName(searchName);

            if (searchItem != null)
            {
                Console.WriteLine();
                Console.WriteLine("Item Found");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"ID: {searchItem.Id}");
                Console.WriteLine($"Name: {searchItem.Name}");
                Console.WriteLine($"Code: {searchItem.Code}");
                Console.WriteLine($"Department: {searchItem.Department}");
                Console.WriteLine($"Unit: {searchItem.Unit}");
                Console.WriteLine($"Opening Stock: {searchItem.OpeningStock}");
                Console.WriteLine($"Current Stock: {searchItem.CurrentStock}");
                Console.WriteLine($"Reorder Level: {searchItem.ReorderLevel}");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }

            break;


        // ====================================
        // 4. UPDATE ITEM
        // ====================================

        case "4":

            Console.Write("Enter item name to update: ");

            string? updateName = Console.ReadLine();

            if (updateName == null)
            {
                Console.WriteLine("Item name is required.");
                break;
            }

            service.UpdateItemName(updateName);

            break;


        // ====================================
        // 5. REMOVE ITEM
        // ====================================

        case "5":

            Console.Write("Enter item name to remove: ");

            string? removeName = Console.ReadLine();

            if (removeName == null)
            {
                Console.WriteLine("Item name is required.");
                break;
            }

            service.RemoveItem(removeName);

            break;


        // ====================================
        // 6. STOCK IN
        // ====================================

        case "6":

            Console.Write("Enter item name: ");

            string? stockInName = Console.ReadLine();

            if (stockInName == null)
            {
                Console.WriteLine("Item name is required.");
                break;
            }

            ItemMaster? stockInItem =
                service.SearchItemName(stockInName);

            if (stockInItem == null)
            {
                Console.WriteLine("Item not found.");
                break;
            }


            Console.Write("Enter quantity: ");

            int stockInQuantity;

            if (!int.TryParse(Console.ReadLine(), out stockInQuantity))
            {
                Console.WriteLine("Invalid quantity.");
                break;
            }


            Console.Write("Enter reference number: ");

            string? stockInReference = Console.ReadLine();

            if (stockInReference == null)
            {
                Console.WriteLine("Reference number is required.");
                break;
            }


            Console.Write("Performed by: ");

            string? stockInUser = Console.ReadLine();

            if (stockInUser == null)
            {
                Console.WriteLine("User name is required.");
                break;
            }


            stockService.StockIn(
                stockInItem,
                stockInQuantity,
                stockInReference,
                stockInUser
            );


            Console.WriteLine(
                $"Stock In successfulg."
            );

            Console.WriteLine(
                $"Current Stock: {stockInItem.CurrentStock}"
            );

            break;


        // ====================================
        // 7. STOCK OUT
        // ====================================

        case "7":

            Console.Write("Enter item name: ");

            string? stockOutName = Console.ReadLine();

            if (stockOutName == null)
            {
                Console.WriteLine("Item name is required.");
                break;
            }


            ItemMaster? stockOutItem =
                service.SearchItemName(stockOutName);

            if (stockOutItem == null)
            {
                Console.WriteLine("Item not found.");
                break;
            }


            Console.Write("Enter quantity: ");

            int stockOutQuantity;

            if (!int.TryParse(Console.ReadLine(), out stockOutQuantity))
            {
                Console.WriteLine("Invalid quantity.");
                break;
            }


            Console.Write("Enter reference number: ");

            string? stockOutReference = Console.ReadLine();

            if (stockOutReference == null)
            {
                Console.WriteLine("Reference number is required.");
                break;
            }


            Console.Write("Performed by: ");

            string? stockOutUser = Console.ReadLine();

            if (stockOutUser == null)
            {
                Console.WriteLine("User name is required.");
                break;
            }


            try
            {
                stockService.Stockout(
                    stockOutItem,
                    stockOutQuantity,
                    stockOutReference,
                    stockOutUser
                );

                Console.WriteLine(
                    "Stock Out successful."
                );

                Console.WriteLine(
                    $"Current Stock: {stockOutItem.CurrentStock}"
                );
            }
            catch (InsufficientStockException ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}"
                );
            }

            break;


        // ====================================
        // 8. STOCK HISTORY
        // ====================================

        case "8":
            movementService.viewMovement();
            break;


        // ====================================
        // 9. STOCK SUMMARY
        // ====================================

        case "9":

            reportService.StockSummary();

            break;


        // ====================================
        // 10. LOW STOCK REPORT
        // ====================================

        case "10":

            reportService.LowStockReport();

            break;


        // ====================================
        // INVALID OPTION
        // ====================================

        default:

            Console.WriteLine(
                "Invalid choice. Please try again."
            );

            break;
    }
}