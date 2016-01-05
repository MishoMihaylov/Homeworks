using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfNNumbers
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int totalCount = 0;

        for (int i = 1; i <= n; i++)
        {
            totalCount += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(totalCount);

    }
}
