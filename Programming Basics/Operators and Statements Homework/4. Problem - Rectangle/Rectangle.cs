using System;

class Rectangle
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter is: {0}", (a * 2) + (b * 2));
        Console.WriteLine("Area is : {0}", a * b);
    }
}
