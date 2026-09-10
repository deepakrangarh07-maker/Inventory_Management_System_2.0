public class Geneerics
{
    public class Box<T>
    {
        public T Value{get; set;}
    }


    public static void main()
    {
        Box<int> name = new();
        name.Value = 525;
    }
}