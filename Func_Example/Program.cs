internal class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> objFunc = Add;
        Console.WriteLine("Add= " + objFunc(20, 10));
        
        Console.ReadLine();
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
