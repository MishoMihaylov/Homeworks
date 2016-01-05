using System;

class DividedBy7And5
{
    static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        Console.WriteLine((a % 5 == 0 && a % 7 == 0) ? "true" : "false");

    }
}
