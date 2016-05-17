using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DistanceInLabyrinth
{
    public static string[,] matrix;

    static void Main(string[] args)
    {
        matrix = new string[,]
        {
            { "0", "0", "0", "x", "0", "x" },
            { "0", "x", "0", "x", "0", "x" },
            { "0", "*", "x", "0", "x", "0" },
            { "0", "x", "0", "0", "0", "0" },
            { "0", "0", "0", "x", "x", "0" },
            { "0", "0", "0", "x", "0", "x" }
        };

        MarkPath();
        PrintMatrix();
    }

    public static void PrintMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;

                if (matrix[i, j] == "0")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                }

                if(matrix[i, j] == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }

                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void MarkPath()
    {
        Stack<Tuple<int, int, int>> cells = new Stack<Tuple<int, int, int>>();
        cells.Push(new Tuple<int, int, int>(2, 1, 1));

        while(cells.Count > 0)
        {
            var currentCell = cells.Pop();
            var X = currentCell.Item1;
            var Y = currentCell.Item2;
            var step = currentCell.Item3;

            matrix[X, Y] = step.ToString();

            if(X < matrix.GetLength(0) - 1)
            {
                if(matrix[X + 1, Y] == "0")
                {
                    cells.Push(new Tuple<int, int, int>(X + 1, Y, step + 1));
                }
            }

            if (Y < matrix.GetLength(1) - 1)
            {
                if (matrix[X, Y + 1] == "0")
                {
                    cells.Push(new Tuple<int, int, int>(X, Y + 1, step + 1));
                }
            }

            if (X - 1 >= 0)
            {
                if (matrix[X - 1, Y] == "0")
                {
                    cells.Push(new Tuple<int, int, int>(X - 1, Y, step + 1));
                }
            }

            if (Y - 1 >= 0)
            {
                if (matrix[X, Y - 1] == "0")
                {
                    cells.Push(new Tuple<int, int, int>(X, Y - 1, step + 1));
                }
            }
        }
    }
}