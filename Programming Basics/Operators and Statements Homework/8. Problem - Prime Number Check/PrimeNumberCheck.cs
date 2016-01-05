using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        int ifPrime;

        do
        {
            Console.WriteLine("Molq vuvedete chislo (do 100): ");
            ifPrime = int.Parse(Console.ReadLine());
        } while (!(ifPrime <= 100));

        if (ifPrime == 1 || ifPrime % 2 == 0 || ifPrime <= 0)
        {
            Console.WriteLine("False");
            return;
        }

        if (ifPrime == 2)
        {
            Console.WriteLine("True");
            return;
        }

        for (int i = 3; i < ifPrime; i+=2)
        {
            if (ifPrime % i == 0)
            {
                Console.WriteLine("False");
                return;
            }
        }
        Console.WriteLine("True");
    }
}
