using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        do
        {
            n = int.Parse(Console.ReadLine());

        } while (n <= 0);

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}

