using System;
using System.Numerics;

class CombinatoricsCalculation
{
    static void Main(string[] args)
    {
        BigInteger result;
        
        int n = int.Parse(Console.ReadLine());

        while (n < 1 || n > 100)
        {
            n = int.Parse(Console.ReadLine());
        }

        int k = int.Parse(Console.ReadLine());

        while (k < 1 || k > 100)
        {
            k = int.Parse(Console.ReadLine());
        }

        result = factorial(n) / (factorial(k) * factorial(n - k));
        Console.WriteLine(result);

    }

    static BigInteger factorial(long number)
    {
        BigInteger FactorialResult = 1;

        for (int i = 1; i <= number; i++)
        {
            FactorialResult *= i;
        }
        return FactorialResult;
    }
}
