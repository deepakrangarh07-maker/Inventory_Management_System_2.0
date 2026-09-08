using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

namespace Inventory_Management_System;

public class ReportService
{
    private ItemMasterService itemMasterService;

    public ReportService(ItemMasterService itemMasterService)
    {
        this.itemMasterService = itemMasterService;
    }
    public void StockSummary()
    {
        List<ItemMaster> items = itemMasterService.GetAllItems();
        foreach (ItemMaster item in items)
        {
            Console.WriteLine("Stock Summary");
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Opening Stock: {item.OpeningStock}");
            Console.WriteLine($"Current Stock: {item.CurrentStock}");
            Console.WriteLine($"Reorder Level: {item.ReorderLevel}");
            Console.WriteLine("----------------------------");
        }

    }
    public void LowStockReport()
    {
        List<ItemMaster> items = itemMasterService.GetAllItems();

        foreach (ItemMaster item in items)
        {
            if(item.CurrentStock <= item.ReorderLevel)
            {
            Console.WriteLine("Low Stock Report");
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Current Stock: {item.CurrentStock}");
            Console.WriteLine($"Reorder Level: {item.ReorderLevel}");
            Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("Not Stock Found Low Stock Report");
            }
        }

    }
}