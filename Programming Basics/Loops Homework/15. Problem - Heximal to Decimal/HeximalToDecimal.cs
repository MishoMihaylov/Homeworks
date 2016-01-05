using System;

class HeximalToDecimal
{
    static void Main(string[] args)
    {

        String n = Console.ReadLine();
        long result = 0;

        for (int i = 0,k = n.Length-1; i < n.Length; i++,k--)
        {
            result += ((long)Math.Pow(16, i) * getCurrentCharInIntNumber(n[k]));
        }

        Console.WriteLine(result);

    }

    static int getCurrentCharInIntNumber(char heximalCharValue)
    {
        switch (heximalCharValue)
        {
            case '0': return 0;
                break;
            case '1': return 1;
                break;
            case '2': return 2;
                break;
            case '3': return 3;
                break;
            case '4': return 4;
                break;
            case '5': return 5;
                break;
            case '6': return 6;
                break;
            case '7': return 7;
                break;
            case '8': return 8;
                break;
            case '9': return 9;
                break;
            case 'A': return 10;
                break;
            case 'B': return 11;
                break;
            case 'C': return 12;
                break;
            case 'D': return 13;
                break;
            case 'E': return 14;
                break;
            case 'F': return 15;
                break;
            default: throw new System.ArgumentException("The given chart is not part of the heximal calculation");
        }
    }
}
