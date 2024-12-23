internal class Program
{
    static void Main(string[] args)
    {
        myDelegate objDele = Add;
        objDele += Sub;
        objDele += Mul;
        objDele += Div;
        objDele(20, 10);
        Console.ReadLine();
    }
    delegate void myDelegate(int a, int b);
    public static void Add(int a, int b)
    {
        Console.WriteLine("Add= " + (a + b));
    }
    public static void Sub(int a, int b)
    {
        Console.WriteLine("Sub= " + (a - b));
    }
    public static void Mul(int a, int b)
    {
        Console.WriteLine("Mul= " + (a * b));
    }
    public static void Div(int a, int b)
    {
        Console.WriteLine("Div= " + (a / b));
    }
}



