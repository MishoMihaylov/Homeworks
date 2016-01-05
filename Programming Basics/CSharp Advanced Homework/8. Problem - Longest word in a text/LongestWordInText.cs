using System;

class Program
{
    static void Main(string[] args)
    {

        String text = Console.ReadLine();
        String[] allWords = text.Split(new char[] {' ','.'}, StringSplitOptions.RemoveEmptyEntries);
        String LongestWord = allWords[0];

        for (int i = 1; i < allWords.Length; i++)
        {
            if (allWords[i].Length > LongestWord.Length)
            {
                LongestWord = allWords[i];
            }
        }

        Console.WriteLine(LongestWord);
    }
}
