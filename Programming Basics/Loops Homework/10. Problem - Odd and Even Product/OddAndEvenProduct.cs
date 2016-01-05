using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        while (true)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(item => int.Parse(item)).ToArray();
            int oddProduct = 1, evenProduct = 1;

            for (int i = 1; i <= numbers.Length ; i++)
            {
                if ((i)%2==0)
                {
                    evenProduct *= numbers[i-1];
                }
                else
                {
                    oddProduct *= numbers[i-1];
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Product = {0}", evenProduct);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Even product = {0}", evenProduct);
                Console.WriteLine("Odd product = {0}", oddProduct);
            }
        }
    }
}

