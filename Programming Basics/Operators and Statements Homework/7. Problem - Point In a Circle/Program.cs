using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedete X");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete Y");
        float y = float.Parse(Console.ReadLine());

        float xCircle = 0;
        float yCircle = 0;
        float rCircle = 2;


        

    }

    //Знам че в C# има sin и cos, но се обърках малко с техните радиани и за да ми стане по-ясно реших да си направя мой функций
    public static float sin(float opposite, float hypotenuse)
    {
        float thisSin = opposite / hypotenuse;
        return thisSin;
    }
    public static float cos(float adjacent, float hypotenuse)
    {
        float thisCos = adjacent / hypotenuse;
        return thisCos;
    }
}
