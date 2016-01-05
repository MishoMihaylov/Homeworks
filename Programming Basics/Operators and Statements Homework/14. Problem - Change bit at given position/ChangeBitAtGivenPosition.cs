using System;

class ChangeBitAtGivenPosition
{
    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int mask = 1;

        if ((number >> p & mask) == v)
        {
            Console.WriteLine("Binary result: {0}, Decimal result: {1}",Convert.ToString(number,2),number);
        }
        else
        {
            
            if((number >> p & 1) == 0)
            {
                mask = 1 << p;
                Console.WriteLine("Binary result: {0}, Decimal result: {1}", Convert.ToString(number | mask, 2), number | mask);
            }
            else if ((number >> p & 1) == 1)
            {
                mask = ~(1 << p);
                Console.WriteLine("Binary result: {0}, Decimal result: {1}", Convert.ToString(number & mask, 2), number & mask);
            }
        }

    }
}
