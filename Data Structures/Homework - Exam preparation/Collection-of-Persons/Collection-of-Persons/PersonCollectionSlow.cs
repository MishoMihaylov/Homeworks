using System.Linq;
using System.Collections.Generic;

public class PersonCollectionSlow : IPersonCollection
{
    private List<Person> personDatabase;

    public PersonCollectionSlow()
    {
        this.personDatabase = new List<Person>();
    }

    public bool AddPerson(string email, string name, int age, string town)
    {
        foreach (var person in this.personDatabase)
        {
            if (person.Email == email)
            {
                return false;
            }
        }

        this.personDatabase.Add(new Person(email, name, age, town));

        return true;
    }

    public int Count
    {
        get
        {
            return this.personDatabase.Count;
        }
    }

    public Person FindPerson(string email)
    {
        foreach (var person in this.personDatabase)
        {
            if(person.Email == email)
            {
                return person;
            }
        }

        return null;
    }

    public bool DeletePerson(string email)
    {
        bool personExist = false;

        foreach (var person in this.personDatabase)
        {
            if(person.Email == email)
            {
                personExist = true;
                break;
            }
        }

        if (!personExist)
        {
            return false;
        }

        this.personDatabase.RemoveAll(x => x.Email == email);

        return true;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        SortedSet<Person> result = new SortedSet<Person>(Comparer<Person>.Create((x, y) => x.Email.CompareTo(y.Email)));

        foreach (var person in this.personDatabase)
        {
            if (person.Email.EndsWith("@" + emailDomain))
            {
                result.Add(person);
            }
        }

        return result;
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        SortedSet<Person> result = new SortedSet<Person>(Comparer<Person>.Create((x, y) => x.Email.CompareTo(y.Email)));

        foreach (var person in this.personDatabase)
        {
            if (person.Name == name && person.Town == town)
            {
                result.Add(person);
            }
        }

        return result;
    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        List<Person> result = new List<Person>();

        foreach (var person in this.personDatabase)
        {
            if (person.Age >= startAge && person.Age <= endAge)
            {
                result.Add(person);
            }
        }

        return result.OrderBy(x => x.Age).ThenBy(x => x.Email);
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        List<Person> result = new List<Person>();

        foreach (var person in this.personDatabase)
        {
            if (person.Age >= startAge && person.Age <= endAge && person.Town == town)
            {
                result.Add(person);
            }
        }

        return result.OrderBy(x => x.Age).ThenBy(x => x.Email);
    }
}
