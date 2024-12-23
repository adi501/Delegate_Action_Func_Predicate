using System;

internal class Program
{
    private static int Result;
    static void Main(string[] args)
    {
        Predicate<Char> objPredicate = isNumber;
        Console.WriteLine("It is Number= " + isNumber('1'));  //True

        //predicate with the Anonymous method
        Predicate<char> objPredicate1 = delegate (Char a)
        {
            return Char.IsNumber(a) ? true : false;
        };
        Console.WriteLine("It is Number= " + objPredicate1('1')); //True
        
        // predicate with Lambda expressions
        Predicate<char> objPredicate2 = (char a) =>
        {
            return Char.IsNumber(a) ? true : false;
        };
        Console.WriteLine("It is Number= " + objPredicate2('1')); //True
        Console.ReadLine();
    }
    public static bool isNumber(char a)
    {
       return Char.IsNumber(a) ? true : false;
    }
}

