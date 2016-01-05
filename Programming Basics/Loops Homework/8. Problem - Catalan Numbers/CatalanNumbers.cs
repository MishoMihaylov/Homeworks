using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 0;

        while (n < 1)
        {
            n = int.Parse(Console.ReadLine());
        }

        result = factorial(2*n)/(factorial(n+1)*factorial(n));
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
