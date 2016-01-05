using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main(string[] args)
    {

        List<int> firstList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
            Select(item => int.Parse(item)).ToList();
        List<int> secondList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
            Select(item => int.Parse(item)).ToList();
        SortedSet<int> allItems = new SortedSet<int>();

        for (int i = 0; i < firstList.Count; i++)
        {
            allItems.Add(firstList[i]);
        }
        foreach (var item in secondList)
        {
            allItems.Add(item);
        }

        allItems.ToList().ForEach(item => Console.Write(item + " "));
    }
}
