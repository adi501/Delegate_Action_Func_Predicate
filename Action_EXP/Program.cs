internal class Program
{
    private static int Result;
    static void Main(string[] args)
    {
        Action<int, int> objaction = Add;
        objaction(20, 10);
        Console.WriteLine("Add= " +Result); //Add= 30

        //Action with an Anonymous method
        Action<int, int> objaction2 = delegate (int a, int b)
        {
            Console.WriteLine("Add= " + (a + b)); //Add= 30
        };
        objaction2(20, 10);

        //Action with a Lambda expression
        Action<int, int> objaction3 = (int a, int b) =>
        { Console.WriteLine("Add= " + (a + b)); };//Add= 30
        objaction3(20, 10);
        Console.ReadLine();
    }
    public static void Add(int a, int b)
    {
        Result= a + b;
    }
}


