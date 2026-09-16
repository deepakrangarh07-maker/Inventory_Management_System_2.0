using Inventory_Management_System.Models;
using LabInventorySystem.Enums;

namespace Inventory_Management_System;

public class StockService
{
    private StockMovementService movementService;
    public StockService(StockMovementService movementService)
    {
        this.movementService = movementService;
    }
    public void StockIn(ItemMaster item, int quantity, string referenceNumber, String performedBy)
    {



        item.CurrentStock += quantity;
        {
            StockMovement movement = new StockMovement
            {
                ItemId = item.Id,
                MovementType = StockTransactionType.StockIn,
                Quantity = quantity,
                MovementDate = DateTime.Now,
                ReferenceNumber = referenceNumber,
                PerformedBy = performedBy
            };
            movementService.AddMovement(movement);
        }
    }
    public void Stockout(ItemMaster item, int quantity, string referenceNumber, string performedBy)
    {
        try
        {
            if (quantity > item.CurrentStock)
            {
                throw new InsufficientStockException("Stock Is Insufficient");
            }
            item.CurrentStock -= quantity;

            StockMovement movement = new StockMovement
            {
                ItemId = item.Id,
                MovementType = StockTransactionType.StockOut,
                Quantity = quantity,
                MovementDate = DateTime.Now,
                ReferenceNumber = referenceNumber,
                // PerformedBy = UserRole.Admin,
                PerformedBy = performedBy,
            };
            movementService.AddMovement(movement);
        }
        catch (InsufficientStockException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}