using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {

        String binaryString = Console.ReadLine();
        long result = 0;

        for (int i = 0, n = binaryString.Length - 1; i < binaryString.Length ; i++, n--)
        {
            result += (long)(Math.Pow(2, i) * (int)Char.GetNumericValue(binaryString[n]));
        }

        Console.WriteLine(result);
    }
}
