internal class Program
{
    private static int Result;
    static void Main(string[] args)
    {
        Predicate<Char> objPredicate = isNumber;
        Console.WriteLine("It is Number= " + isNumber('1'));
        //predicate with the Anonymous method
        Predicate<char> objPredicate1 = delegate (Char a)
        {
            return Char.IsNumber(a) ? true : false;
        };
        Console.WriteLine("It is Number= " + objPredicate1('1'));
        Console.ReadLine();
    }
    public static bool isNumber(char a)
    {
       return Char.IsNumber(a) ? true : false;
    }
}
