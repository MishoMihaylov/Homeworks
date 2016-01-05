using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {

        long n = long.Parse(Console.ReadLine());
        String result = "";

        while(n>=1)
        {
            if (n % 2 != 0)
            {
                result = "1" + result;
            }
            else
            {
                result = "0" + result;
            }
            n = n / 2;
        }

        Console.WriteLine(result);
    }
}