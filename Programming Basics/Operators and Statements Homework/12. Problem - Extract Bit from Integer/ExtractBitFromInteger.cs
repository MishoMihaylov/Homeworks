using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1;

        Console.WriteLine(number >> p & mask);
    }
}
