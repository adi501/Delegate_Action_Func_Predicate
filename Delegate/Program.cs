internal class Program
{
    static void Main(string[] args)
    {
        myDelegate objDele = Add;
        objDele(10, 20);
        Console.ReadLine();
    }
    delegate void myDelegate(int a, int b);
    public static void Add(int a, int b)
    {
        Console.Write("Add= " + (a + b));
    }
}



