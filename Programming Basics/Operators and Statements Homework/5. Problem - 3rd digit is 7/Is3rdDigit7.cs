using System;

class Is3rdDigit7
{
    static void Main(string[] args)
    {

        float a = int.Parse(Console.ReadLine());

        if (a < 700)
        {
            Console.WriteLine("False");
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                a = a / 10;

                if (i == 2)
                {
                    if (Math.Abs(a - Math.Floor(a)) >= 0.70 && Math.Abs(a - Math.Floor(a)) < 0.8)
                    {
                        Console.WriteLine("True");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("False");
                        break;
                    }
                }
            }
        }
    }
}
