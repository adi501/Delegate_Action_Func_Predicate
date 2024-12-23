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
        Console.WriteLine("Add= " + (a + b)); //Add= 20
    }
    public static void Sub(int a, int b)
    {
        Console.WriteLine("Sub= " + (a - b)); //Sub= 10
    }
    public static void Mul(int a, int b)
    {
        Console.WriteLine("Mul= " + (a * b)); //Mul= 200
    }
    public static void Div(int a, int b)
    {
        Console.WriteLine("Div= " + (a / b)); //Div= 2
    }
}



