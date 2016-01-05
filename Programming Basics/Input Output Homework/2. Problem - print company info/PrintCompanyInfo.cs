using System;

class PrintCompanyInfo
{
    static void Main(string[] args)
    {

        //A company has name, address, phone number, fax number, web site and manager.
        //The manager has first name, last name, age and a phone number. 
        //    Write a program that reads the information about a company and its 
        //manager and prints it back on the console.

        String companyName = Console.ReadLine();
        String Adress = Console.ReadLine();
        int PhoneNumber = int.Parse(Console.ReadLine());
        int FaxNumber = int.Parse(Console.ReadLine());
        String WebSite = Console.ReadLine();
        String ManagerFirstName = Console.ReadLine();
        String ManagerLastName = Console.ReadLine();
        int ManagerAge = int.Parse(Console.ReadLine());
        int ManagerPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(companyName);
        Console.WriteLine("Adress: " + Adress);
        Console.WriteLine("Phone: " + PhoneNumber);
        Console.WriteLine("Fax: " + FaxNumber);
        Console.WriteLine("WebSite: " + WebSite);
        Console.WriteLine("Manager: " + ManagerFirstName + " " + ManagerLastName + "( age: " + ManagerAge + ", " 
            + "Phone: " + ManagerPhoneNumber + " )");




    }
}
