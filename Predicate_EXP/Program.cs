internal class Program
{
    private static int Result;
    static void Main(string[] args)
    {
        Predicate<Char> objaction = isNumber;
        Console.WriteLine("It is Number= " + isNumber('1'));
        
        Console.ReadLine();
    }
    public static bool isNumber(char a)
    {
       return Char.IsNumber(a) ? true : false;
    }
}
