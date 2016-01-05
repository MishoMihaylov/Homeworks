using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sum5Numbers
{
    static void Main(string[] args)
    {
        int[] Numbers = new int[5];
        Numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(item => int.Parse(item)).ToArray();
        int totalCount = 0;

        foreach (var item in Numbers)
        {

            totalCount += item;

        }

        Console.WriteLine("Sum is:{0}", totalCount);
    }
}
