using System;
using System.Collections.Generic;
using System.Linq;

class ExtractURLs
{
    static void Main(string[] args)
    {

        String text = Console.ReadLine();
        var URLs = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).
            Where(item => (item.StartsWith("http://") && (item.EndsWith(".com") || item.EndsWith(".bg"))
                || item.StartsWith("www.") && (item.EndsWith(".com") || item.EndsWith(".bg"))));

        foreach (var URL in URLs)
        {
            Console.WriteLine(URL);
        }
    }
}
