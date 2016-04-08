using System;
using System.Linq;

class ReverseArray
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Reverse(array, 0 , array.Length - 1);
        Console.WriteLine(string.Join(" ", array));
    }

    private static void Reverse(int[] array, int startingIndex, int endIndex)
    {
        if(startingIndex == endIndex || startingIndex+1 == endIndex)
        {
            Swap(ref array[startingIndex], ref array[endIndex]);
            return;
        }

        Swap(ref array[startingIndex], ref array[endIndex]);
        Reverse(array, startingIndex + 1, endIndex - 1);
    }

    private static void Swap(ref int a, ref int b)
    {
        if(a == b)
        {
            return;
        }
        int oldValue = a;
        a = b;
        b = oldValue;
    }
}