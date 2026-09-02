namespace Inventory_Management_System.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Code { get; set; } = "";

    public int Stock { get; set; }
}