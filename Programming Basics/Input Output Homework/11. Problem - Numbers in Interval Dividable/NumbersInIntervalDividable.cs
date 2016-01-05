using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersInIntervalDividable
{
    static void Main(string[] args)
    {

        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int pNumbers = 0;

        for (int i = 0; i < 5; i++)
        {
            if (startNumber % 5 == 0)
            {
                break;
            }
            else
            {
                startNumber++;
            }
        }

        for (int i = startNumber; i <= endNumber; )
        {
            pNumbers++;
            i += 5;
        }

        Console.WriteLine(pNumbers);

    }
}
