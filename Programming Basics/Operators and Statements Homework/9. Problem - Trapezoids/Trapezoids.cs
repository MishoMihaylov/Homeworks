using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedete stoinostite: ");
        Console.Write("a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("h: ");
        float h = float.Parse(Console.ReadLine());

        float area = ((a + b) / 2) * h;

        Console.WriteLine("The Area is: {0}", area);
    }
}
