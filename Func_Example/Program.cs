internal class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> objFunc = Add;
        Console.WriteLine("Add= " + objFunc(20, 10)); //Add= 30

        //Func with an Anonymous Method
        Func<int, int, int> objfuc2 = delegate (int a, int b)
        {
            return a + b;
        };
        Console.WriteLine("Add= " + objfuc2(20, 10)); //Add= 30
        
        //Func with Lambda Expression
        Func<int, int, int> objfuc3 = (int a, int b) => (a + b);
        Console.WriteLine("Add= " + objfuc3(20, 10)); //Add= 30
        Console.ReadLine();
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
}


