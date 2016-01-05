using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers you would like to type? ");
        int n = int.Parse(Console.ReadLine());

        while (n < 1)
        {
            Console.WriteLine("You have to add some numbers, try again: ");
            n = int.Parse(Console.ReadLine());
        }

        List<int> numbers = new List<int>();

        Console.WriteLine("Alright, so what are the numbers: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Number {0}: ",i+1);
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        // Select sort

        int currentBiggestElementIndex;
        int temp;

        for (int i = 0; i < numbers.Count-1; i++)
        {
            currentBiggestElementIndex = i;
            for (int k = i + 1; k < numbers.Count; k++)
            {
                if (numbers[currentBiggestElementIndex] >= numbers[k])
                {
                    currentBiggestElementIndex = k;
                }
            }
            if (numbers[currentBiggestElementIndex] != numbers[i])
            {
                temp = numbers[i];
                numbers[i] = numbers[currentBiggestElementIndex];
                numbers[currentBiggestElementIndex] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }


    }
}
