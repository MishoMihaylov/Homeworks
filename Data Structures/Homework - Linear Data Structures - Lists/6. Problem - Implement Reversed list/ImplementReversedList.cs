using System;

class ImplementReversedList
{
    static void Main(string[] args)
    {
        var reversedList = new ReversedList<int>();
        reversedList.Add(0);
        reversedList.Add(1);
        reversedList.Add(2);
        reversedList.Add(3);
        reversedList.Add(4);

        reversedList.Remove(2);

        Console.WriteLine(string.Join(" ", reversedList));
    }
}