using System;

class DivisionOfTwoFactorials
{
    static void Main(string[] args)
    {
        int N, K,n=1,k=1;
        
        do
        {
            Console.Write("Type N(1<N<100): ");
            N = int.Parse(Console.ReadLine());
        } while(N < 0 || N > 100);

        do
        {
            Console.Write("Type K(1<K<100): ");
            K = int.Parse(Console.ReadLine());
        } while(K < 0 || K > 100);

        for (int i = 1; i <= (N >= K ? N : K); i++)
        {
            if (N >= K)
            {
                n *= i;
                if (i <= K)
                {
                    k *= i;
                }
            }
            else
            {
                k *= i;
                if (i <= N)
                {
                    n *= i;
                }
            }
        }
    }
}

