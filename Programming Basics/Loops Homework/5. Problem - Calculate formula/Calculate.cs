using System;

class Calculate
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = i*factorial;
            sum += (factorial/ (Math.Pow(x, i)));
        }

        Console.WriteLine("{0:0.00000}", sum);
    }
}
