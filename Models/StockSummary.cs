namespace Inventory_Management_System.Models;



public class StockSummary()
{
    public string ItemName{get;} ="";
    public int CurrentStock{get;}
    public int OpeningStock{get;}
    public int StockIn{get;}
    public int Stockout{get;}

    public int ReorderLevel{get;}
}