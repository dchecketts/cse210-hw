class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello world");
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.Write(myCircle.GetArea());
    }
}