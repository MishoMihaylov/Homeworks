using System;

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.Write("Enter Weight: ");
        float weight = float.Parse(Console.ReadLine());
        Console.WriteLine("Weight on the moon: {0}", weight * 0.17);
    }
}
