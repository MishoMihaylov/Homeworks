using System;

class MinMaxSumAvg
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        float number, max = 0, min = 0, sum = 0;

        for (int i = 0; i < n; i++)
        {
           number = float.Parse(Console.ReadLine());

           sum += number; 
           if (number > max)
           {
               max = number;
           }
           if (i == 0) { min = number; };
           if (number < min)
           {
               min = number;
           }
        }

        Console.WriteLine("Min: {0}",min);
        Console.WriteLine("Max: {0}",max);
        Console.WriteLine("Sum: {0}",sum);
        Console.WriteLine("Avg: {0:0.00}",sum / n);
    }
}
