using System;
using System.Collections.Generic;
using System.Linq;

class PLongestSubsequencerogram
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x))
            .ToList();

        Console.WriteLine(string.Join(" ", FindLongestEqualSubsequence(list)));
    }

    public static List<int> FindLongestEqualSubsequence(List<int> list)
    {
        int digitOfTheSub = list[0];
        int longestCount = 0;
        int currentDigit;
        int currentCount = 0;

        for (int i = 0; i < list.Count; i++)
        {
            currentCount = 1;
            currentDigit = list[i];
            for (int j = i + 1; j < list.Count; j++)
            {
                if(list[i] == list[j])
                {
                    currentCount++;
                }
                else
                {
                    break;
                }
            }

            if(currentCount > longestCount)
            {
                longestCount = currentCount;
                digitOfTheSub = currentDigit;
            }
        }

        var result = new List<int>();
        for (int i = 0; i < longestCount; i++)
        {
            result.Add(digitOfTheSub);
        }

        return result;
    }
}