using System;
using System.Collections.Generic;

class FindPathsInMatrix
{
    static LinkedList<char> path = new LinkedList<char>();
    static char[,] matrix = { {'s', ' ', ' ', ' ', ' ', ' ' },
                              {' ', '*', '*', ' ', '*', ' ' },
                              {' ', '*', '*', ' ', '*', ' ' },
                              {' ', '*', 'e', ' ', ' ', ' ' },
                              {' ', ' ', ' ', '*', ' ', ' ' } };

    static int totalPathsFound = 0;

    static void Main(string[] args)
    {
        FindPaths(0, 0);
        Console.WriteLine(totalPathsFound);
    }

    private static void FindPaths(int x, int y, char symbol = 'S')
    {
        if (x < 0 || y < 0 || x == matrix.GetLength(0)|| y == matrix.GetLength(1))
        {
            return;
        }

        
        if(matrix[x, y] == 'e')
        {
            path.AddLast(symbol);
            Console.WriteLine(string.Join("", path));
            path.RemoveLast();
            totalPathsFound += 1;
            return;
        }   

        if(matrix[x, y] != ' ' && matrix[x, y] != 's')
        {
            return;
        }

        MarkCell(x, y);
        path.AddLast(symbol);
        FindPaths(x, y - 1, 'L'); //left
        FindPaths(x, y + 1, 'R'); //right
        FindPaths(x - 1, y, 'U'); //up
        FindPaths(x + 1, y, 'D'); //down
        path.RemoveLast();
        UnMarkCell(x, y);
    }

    private static void MarkCell(int x, int y)
    {
        matrix[x, y] = 'M';
    }
    
    private static void UnMarkCell(int x, int y)
    {
        matrix[x, y] = ' ';
    }
}
