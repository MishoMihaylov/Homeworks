using System;

class PrintCardsDeck
{
    static void Main(string[] args)
    {

        string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        char[] cardSymbols = {'♥','♦','♠','♣'};

        for (int i = 0; i < cards.Length; i++)
        {
            for (int n = 0; n < cardSymbols.Length; n++)
            {
                Console.Write(cards[i] + cardSymbols[n] + " ");
            }
            Console.WriteLine();
        }

    }
}
