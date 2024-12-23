internal class Program
{
    private static int Result;
    static void Main(string[] args)
    {
        Action<int, int> objaction = Add;
        objaction(20, 10);
        Console.WriteLine("Add= " +Result);
        Console.ReadLine();
    }
    public static void Add(int a, int b)
    {
        Result= a + b;
    }
}
