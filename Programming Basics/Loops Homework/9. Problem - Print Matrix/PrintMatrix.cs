using System;

class PrintMatrix
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        while (n < 1 || n > 20)
        {
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            for (int k = 1; k < n; k++)
            {
                Console.Write("{0} ",i + k);
            }
            Console.WriteLine();
        }
    }
}
