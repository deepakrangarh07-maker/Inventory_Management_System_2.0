public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(string Message)
    : base("Product was not found.")
    {

    }
}