using System;

class NestedLoopsRecursion
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] line = new int[n];

        ExecuteNestedLoopRecursion(0, n, line);
    }

    private static void ExecuteNestedLoopRecursion(int index, int numberOfIterations, int[] line)
    {
        if (index == line.Length)
        {
            Console.WriteLine(string.Join(" ", line));
            return;
        }

        for (int i = 1; i <= numberOfIterations; i++)
        {
            line[index] = i;
            ExecuteNestedLoopRecursion(index + 1, numberOfIterations, line);
        }
    }
}
