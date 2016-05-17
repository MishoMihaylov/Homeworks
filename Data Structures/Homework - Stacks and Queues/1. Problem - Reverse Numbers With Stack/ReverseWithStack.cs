using System;
using System.Collections.Generic;
using System.Linq;

class ReverseWithStack
{
    static void Main(string[] args)
    {

        Stack<int> numbersStorage = new Stack<int>();

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        foreach(var number in numbers)
        {
            numbersStorage.Push(number);
        }

        while (numbersStorage.Any())
        {
            Console.Write("{0} ", numbersStorage.Pop());
        }

    }
}