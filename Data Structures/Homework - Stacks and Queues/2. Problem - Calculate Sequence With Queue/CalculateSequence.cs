using System;
using System.Collections.Generic;
using System.Linq;

class CalculateSequence
{
    static void Main(string[] args)
    {
        const int DesiredCount = 50;
        int N = int.Parse(Console.ReadLine());
        Queue<int> numbersStorage = new Queue<int>();
        Queue<int> baseNumberStorage = new Queue<int>();
        baseNumberStorage.Enqueue(N);
        int baseNumber;
        int currentNumber;

        for (int i = 0; i < DesiredCount; i += 3)
        {
            baseNumber = baseNumberStorage.Dequeue();

            currentNumber = baseNumber + 1;
            numbersStorage.Enqueue(currentNumber);
            baseNumberStorage.Enqueue(currentNumber);

            currentNumber = (baseNumber * 2) + 1;
            numbersStorage.Enqueue(currentNumber);
            baseNumberStorage.Enqueue(currentNumber);

            currentNumber = baseNumber + 2;
            numbersStorage.Enqueue(currentNumber);
            baseNumberStorage.Enqueue(currentNumber);
        }

        Console.Write(N + " ");
        for (int i = 0; i < DesiredCount; i++)
        {
            Console.Write("{0} ", numbersStorage.Dequeue());
        }

    }
}