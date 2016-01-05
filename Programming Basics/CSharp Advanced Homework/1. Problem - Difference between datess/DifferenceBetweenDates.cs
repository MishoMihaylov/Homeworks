using System;
using System.Globalization;
using System.Threading;

class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        CultureInfo myCulture = new CultureInfo("en-GB");
        Thread.CurrentThread.CurrentCulture = myCulture;

        String firstDate = Console.ReadLine();
        String secondDate = Console.ReadLine();

        DateTime firstD = DateTime.Parse(firstDate);
        DateTime secondD = DateTime.Parse(secondDate);

        Console.WriteLine((secondD - firstD).Days);
    }
}

