using System;
using System.Collections.Generic;
using System.Linq;

class CountOfOccurences
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        Dictionary<int, int> numbers = new Dictionary<int, int>();

        foreach (var element in array)
        {
            if (numbers.ContainsKey(element))
            {
                numbers[element]++;
            }
            else
            {
                numbers.Add(element, 1);
            }
        }

        foreach(var pair in numbers.OrderBy(x => x.Key))
        {
            Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
        }
    }
}