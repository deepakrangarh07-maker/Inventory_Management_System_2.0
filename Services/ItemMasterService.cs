using Inventory_Management_System.Models;

namespace Inventory_Management_System.Services;

public class ItemMasterService
{
    private List<ItemMaster> itemMasters = new List<ItemMaster>();
    public void AddProduct(ItemMaster item)
    {
        ItemMaster? existingItem = itemMasters.Find(existingItem => existingItem.Name == item.Name);
        if(existingItem != null)
        {
            Console.WriteLine("Duplicate Item found");
            return; 
        }

        // This Code Find the existing code value : 

        ItemMaster? existingItemCode = itemMasters.Find(existingItemCode => existingItemCode.Code == item.Code);
       
        if(existingItemCode != null)
        {
            Console.WriteLine("Duplicate Code Found");
            return;
        }

        item.CurrentStock = item.OpeningStock;
        itemMasters.Add(item);

        Console.WriteLine("Item added successfully.");
    }
    // public void RemoveItem



    // this code is print all the product into the program
    public List<ItemMaster> GetAllItems()
    {
        return itemMasters;
    }
}

