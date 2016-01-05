using System;

class LongestAreaInArray
{
    static void Main(string[] args)
    {
        int LongestSequence = 0,currentSequence = 0;
        String MostRepeatableSentence, CurrentRepeatableSequence;

        Console.WriteLine("Please, type how many senteces u want to type? ");
        int n = int.Parse(Console.ReadLine());

        while (n < 1)
        {
            Console.WriteLine("You have to add some sentencese, try again: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ok, enter your senteces:");
        String[] StringArray = new String[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}: ",i+1);
            StringArray[i] = Console.ReadLine();
        }

        LongestSequence = currentSequence = 1;
        MostRepeatableSentence = CurrentRepeatableSequence = StringArray[0];

        for (int i = 1; i < n; i++)
        {
            if (StringArray[i] == StringArray[i - 1])
            {
                currentSequence++;
            }
            else
            {
                if (LongestSequence < currentSequence)
                {
                    LongestSequence = currentSequence;
                    MostRepeatableSentence = StringArray[i - 1];
                }

                currentSequence = 1;
            }
        }

        if (LongestSequence < currentSequence)
        {
            LongestSequence = currentSequence;
            MostRepeatableSentence = StringArray[n-1];
        }

        Console.WriteLine(LongestSequence);

        for (int i = 0; i < LongestSequence; i++)
        {
            Console.WriteLine(MostRepeatableSentence);
        }

    }
}