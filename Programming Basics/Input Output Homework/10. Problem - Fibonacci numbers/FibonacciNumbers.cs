using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FibonacciNumbers
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int lastNumber = 1, beforeLastNumber = 0, tempLast;

        if (n == 1)
        {
            Console.WriteLine("0");
            return;
        }
        else if (n == 2)
        {
            Console.WriteLine("0, 1");
            return;
        }
        else if (n <= 0)
        {

            Console.WriteLine("Invalid number");
            return;
        }
        else
        {
            Console.Write("0, 1");
        }

        for (int i = 2; i < n; i++)
        {
            Console.Write(", {0}", lastNumber + beforeLastNumber);
            tempLast = lastNumber;
            lastNumber = lastNumber + beforeLastNumber;
            beforeLastNumber = tempLast;
        }

    }
}
