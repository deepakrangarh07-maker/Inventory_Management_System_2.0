namespace LabInventorySystem.Models;

using LabInventorySystem.Enums;


public class User
{
    public int Id {get; set;}
    public string Name {get; set;}
    public UserRole Role {get; set;}
}