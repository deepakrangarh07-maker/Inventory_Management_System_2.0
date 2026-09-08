namespace Inventory_Management_System.Models;


public class StockMovement
{
    public int Id{get; set;}
    public int ItemId { get; set;}
    public string MovementType { get; set;} = "";
    public int Quantity { get; set;}
    public DateTime MovementDate { get; set;}
    public string  ReferenceNumber { get; set;} ="";
    public string PerformedBy { get; set;} = "";
}