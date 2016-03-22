using System;
using System.IO;
using Wintellect.PowerCollections;

class Demo
{
    static void Main(string[] args)
    {
        const string fileName = "students.txt";

        string input = Console.ReadLine();

        using (StreamWriter newWriter = File.AppendText(fileName))
        {
            while (input != "end")
            {
                newWriter.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    
        var dataStorage = new OrderedDictionary<string, OrderedDictionary<string, Person>>();

        using (var streamReader = new StreamReader(fileName))
        {
            string currentLine;

            while ((currentLine = streamReader.ReadLine()) != null)
            {
                string[] parameters = currentLine.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                string firstName = parameters[0];
                string lastName = parameters[1];
                string course = parameters[2];

                if (!dataStorage.ContainsKey(course))
                {
                    dataStorage.Add(course, new OrderedDictionary<string, Person>());
                }

                if (!dataStorage[course].ContainsKey(lastName))
                {
                    dataStorage[course].Add(lastName, new Person(firstName, lastName));
                }
            }
        }

        foreach (var course in dataStorage)
        {
            Console.Write($"{course.Key} -> ");
            string peopleInCourse = "";
            foreach (var person in course.Value)
            {
                peopleInCourse += ", " + person.Value.ToString();
            }

            peopleInCourse = peopleInCourse.Remove(0, 2);
            Console.WriteLine(peopleInCourse);
        }
    }
}
