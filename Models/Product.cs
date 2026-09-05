namespace Inventory_Management_System.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Code { get; set; } = "";

    public string Department { get; set; } = "";
    public string Unit { get; set; } = "";
    public int OpeningStock { get; set; }
    public int ReorderLevel {get; set;}
    public int CurrentStock { get; set; }


}