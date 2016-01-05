using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {

        float fourDigitNumber = float.Parse(Console.ReadLine());
        float sumOfTheDigits = 0;
        string fourDigitString;

        fourDigitString = fourDigitNumber.ToString();

        for (int i = 0; i < 4; i++)
        {
            sumOfTheDigits += float.Parse(fourDigitString.ToCharArray()[i].ToString());
        }
        //Sum of the digits
        Console.WriteLine("Sum of the numbers is {0}", sumOfTheDigits);
        
        //Reversed number
        Console.WriteLine("Number reversed looks like {0}", reverseString(fourDigitString));

        //Last digit goes at first position
        Console.WriteLine("With last digit on first position looks like: {0}{1}{2}{3}",
            fourDigitString.ToCharArray()[3],
            fourDigitString.ToCharArray()[0],
            fourDigitString.ToCharArray()[1],
            fourDigitString.ToCharArray()[2]);

        //2nd and 3rd digits exchange
        Console.WriteLine("2nd and 3rd digits are exchanged: {0}{1}{2}{3}",
            fourDigitString.ToCharArray()[0],
            fourDigitString.ToCharArray()[2],
            fourDigitString.ToCharArray()[1],
            fourDigitString.ToCharArray()[3]);
    }
     public static string reverseString(string a)
    {
        char[] charArray = a.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
