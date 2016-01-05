using System;

class BitwiseExtract
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int mask = 1;

        Console.WriteLine(n>>3 & mask);

    }
}
