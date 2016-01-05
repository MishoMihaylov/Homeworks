using System;
using System.Linq;

class FormattingNumbers
{
    static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        String aa = Convert.ToString(a, 2).PadLeft(10,'0');

        Console.Write("|");
        Console.Write("{0,-10:X}",a);
        Console.Write("|");
        Console.Write("{0,10}",aa);
        Console.Write("|");
        Console.Write("{0,10:F2}",b);
        Console.Write("|");
        Console.Write("{0,-10:F3}", c);
        Console.Write("|");

        Console.WriteLine();


    }
}
