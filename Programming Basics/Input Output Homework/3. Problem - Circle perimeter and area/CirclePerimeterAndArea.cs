using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {

        float r = float.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter: " + Math.Round(2*r*Math.PI,2));
        Console.WriteLine("Area: " + Math.Round( Math.PI * Math.Pow(r, 2),2));

    }
}