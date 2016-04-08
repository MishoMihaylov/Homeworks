using System;
using System.Linq;
using System.Collections.Generic;

class TowerOfHanoi
{
    static Stack<int> startingRod;
    static Stack<int> spareRod = new Stack<int>();
    static Stack<int> destinationRod = new Stack<int>();

    static int stepsTaken = 0;

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        startingRod = new Stack<int>(Enumerable.Range(1, n).Reverse());
        Console.WriteLine("#0 - Starting rods position:");
        PrintPegs();
        MoveDisk(startingRod, spareRod, destinationRod, n);
    }

    private static void MoveDisk(Stack<int> startingRod, Stack<int> spareRod, Stack<int> destinationRod, int bottomDisksCount)
    {
        if(bottomDisksCount == 1)
        {
            stepsTaken += 1;
            Console.WriteLine($"#{stepsTaken}: Moving disk: {startingRod.Peek()} ");
            destinationRod.Push(startingRod.Pop());
            PrintPegs();
        }
        else
        {
            MoveDisk(startingRod, destinationRod, spareRod, bottomDisksCount - 1);
            stepsTaken += 1;
            Console.WriteLine($"#{stepsTaken}: Moving disk: {startingRod.Peek()} ");
            destinationRod.Push(startingRod.Pop());
            PrintPegs();
            MoveDisk(spareRod, startingRod, destinationRod, bottomDisksCount - 1);
        }
    }

    private static void PrintPegs()
    {
        Console.WriteLine("Source: {0}", string.Join(" ", startingRod.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(" ", destinationRod.Reverse()));
        Console.WriteLine("Middle: {0}", string.Join(" ", spareRod.Reverse()));
        Console.WriteLine();
    }
}

