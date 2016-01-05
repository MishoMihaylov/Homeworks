using System;

class RandomNums
{
    static void Main(string[] args)
    {
        Random generate = new Random();

        Console.Write("Type n: ");
        int n = int.Parse(Console.ReadLine());
        while (n <= 0)
        {
            Console.Write("Invalid Value. Type again n: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.Write("Type min: ");
        int min = int.Parse(Console.ReadLine());
        while (min < 0)
        {
            Console.Write("Invalid Value. Type again min: ");
            min = int.Parse(Console.ReadLine());
        }

        Console.Write("Type max: ");
        int max = int.Parse(Console.ReadLine());
        while (max <= min)
        {
            Console.Write("Invalid Value. Type again max: ");
            max = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ",generate.Next(min,max+1));
        }
        Console.WriteLine();

    }
}
