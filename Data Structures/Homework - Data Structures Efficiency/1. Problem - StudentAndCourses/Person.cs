using System;

public class Person : IComparable
{
    private string firstName;
    private string lastName;

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("FirstName cannot be null or whitespaces");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("LastName cannot be null or whitespaces");
            }

            this.lastName = value;
        }
    }

    public int CompareTo(object obj)
    {
        Person otherPerson = obj as Person;

        return this.LastName.CompareTo(otherPerson.LastName);
    }

    public override string ToString()
    {
        return this.FirstName + " " + this.LastName;
    }
}
