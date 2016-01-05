using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddOrEven
{
    static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());

        Console.WriteLine(a % 2 == 0 ? "Even" : "Odd");


    }
}