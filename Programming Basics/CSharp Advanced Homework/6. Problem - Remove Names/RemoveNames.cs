using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main(string[] args)
    {

        List<String> firstList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<String> secondList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < firstList.Count; i++)
        {
            for (int n = 0; n < secondList.Count; n++)
            {
                if (firstList[i] == secondList[n])
                {
                    firstList.RemoveAll(item => item == secondList[n]);
                }
            }
        }

        foreach (var item in firstList)
        {
            Console.Write(item + " ");
        }

    }
}
