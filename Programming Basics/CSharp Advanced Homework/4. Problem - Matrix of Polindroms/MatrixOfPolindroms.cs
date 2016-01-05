using System;

class MatrixOfPolindroms
{
    static void Main(string[] args)
    {

        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());

        for (int i = 0; i < row; i++)
        {
            for (int n = 0; n < column; n++)
            {
                Console.Write("{0}{1}{0} ", Convert.ToChar(i + 97), Convert.ToChar(n + 97 + i));
            }
            Console.WriteLine();
        }

    }
}
