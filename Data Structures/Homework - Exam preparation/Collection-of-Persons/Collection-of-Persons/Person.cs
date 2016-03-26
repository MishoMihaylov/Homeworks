using System;

public class Person : IPerson, IComparable
{
    public Person(string email, string name, int age, string town)
    {
        this.Email = email;
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public string Email { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }

    public int CompareTo(object obj)
    {
        var comparedItem = obj as Person;

        return this.Email.CompareTo(comparedItem.Email);
    }
}
