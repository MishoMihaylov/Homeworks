using System;
using System.Collections.Generic;
using System.Linq;

class SumAndAverage
{
    static void Main(string[] args)
    {

        List<int> list = new List<int>();
        list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x))
            .ToList();

        Console.WriteLine("Sum: {0}, Average: {1}", list.Sum(), (double)list.Sum()/list.Count);
    }
}