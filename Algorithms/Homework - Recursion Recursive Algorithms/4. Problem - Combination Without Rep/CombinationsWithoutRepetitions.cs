using System;

class CombinationsWithoutRepetitions
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int lineLenght = int.Parse(Console.ReadLine());
        int[] printLine = new int[lineLenght];

        MakeCombinations(numbersCount, 0, lineLenght, printLine);
    }

    private static void MakeCombinations(int numbersCount, int index, int lineLenght, int[] printLine, int currentNumber = 0)
    {
        if (index > lineLenght - 1)
        {
            Console.WriteLine(string.Join(" ", printLine));
            return;
        }

        for (int i = 1; i <= numbersCount; i++)
        {
            if (i > currentNumber)
            {
                printLine[index] = i;
                MakeCombinations(numbersCount, index + 1, lineLenght, printLine, i);
            }
        }
    }
}
