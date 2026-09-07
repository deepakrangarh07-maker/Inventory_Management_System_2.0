using Inventory_Management_System.Models;

namespace Inventory_Management_System;

public class StockService
{
    public void StockIn(ItemMaster item, int quantity)
    {
        item.CurrentStock += quantity;
    }
  
    public  void Stockout(ItemMaster item, int quantity)
    {
        try
        {
            if (quantity > item.CurrentStock)
            {
                throw new InsufficientStockException("Stock Is Insufficient");
            }
            item.CurrentStock -= quantity;
        }
        catch (InsufficientStockException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}