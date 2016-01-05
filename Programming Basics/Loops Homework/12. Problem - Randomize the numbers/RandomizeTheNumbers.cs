using System;
using System.Linq;
using System.Collections.Generic;

class RandomizeTheNumbers
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        Random Generate = new Random();
        int temp;

        while(n<=0){
            n = int.Parse(Console.ReadLine());
        }

        List<int> storedNumbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            storedNumbers.Add(i);
            storedNumbers[i] = i + 1;
        }

        for (int i = 0; i < n; i++)
        {
            temp = Generate.Next(0,storedNumbers.Count-1);
            Console.Write("{0} ", storedNumbers[temp]);
            storedNumbers.RemoveAt(temp);
        }
    }
}
