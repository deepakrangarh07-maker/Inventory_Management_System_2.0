using Inventory_Management_System.Models;

public class StockMovementService
{
     private List<StockMovement> stockMovements = new List<StockMovement>();

     private int nextMovementId = 1;
     public void AddMovement(StockMovement movement)
    {
        movement.Id = nextMovementId;
        nextMovementId++;

        stockMovements.Add(movement);
    }

    public void viewMovement()
    {
        foreach(StockMovement movement in stockMovements)
        {
            Console.WriteLine($"ID: {movement.Id}");
            Console.WriteLine($"Item ID: {movement.ItemId}");
            Console.WriteLine($"Movement Type: {movement.MovementType}");
            Console.WriteLine($"Quantity: {movement.Quantity}");
            Console.WriteLine($"Date: {movement.MovementDate}");
            Console.WriteLine($"Reference Number: {movement.ReferenceNumber}");
            Console.WriteLine($"Performed By: {movement.PerformedBy}");
            Console.WriteLine("----------------------------");
        }
    }
}