using System;
using System.Collections.Generic;
using System.Linq;

class SortWords
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        list.Sort();

        Console.WriteLine(String.Join(", ", list));
    }
}