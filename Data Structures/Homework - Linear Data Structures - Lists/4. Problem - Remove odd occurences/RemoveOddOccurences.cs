using System;
using System.Collections.Generic;
using System.Linq;

class RemoveOddOccurences
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        List<int> evens = new List<int>();
        list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x))
            .ToList();

        int currentNumber;
        int currentCount = 0;

        for (int i = 0; i < list.Count; i++)
        {
            currentCount = 1;
            currentNumber = list[i];
            if (evens.Contains(currentNumber)){
                evens.Add(currentNumber);
                continue;
            }

            for (int j = i+1; j < list.Count; j++)
            {
                if(currentNumber == list[j])
                {
                    currentCount++;
                }
            }

            if(currentCount % 2 != 0)
            {
                list.RemoveAll(x => x == currentNumber);
                i--;
            }
            else
            {
                evens.Add(currentNumber);
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
}