using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

public class PersonCollection : IPersonCollection
{
    private Dictionary<string, Person> personDatabase;
    private Dictionary<string, SortedSet<Person>> databaseOrderedByDomain;
    private Dictionary<string, SortedSet<Person>> databaseOrderedByNameAndTown;
    private OrderedDictionary<int, SortedSet<Person>> databaseOrderedByAgeAndEmail;
    private Dictionary<string, OrderedDictionary<int, SortedSet<Person>>> databaseOrderedByAgeTownAndEmail;

    public PersonCollection()
    {
        this.personDatabase = new Dictionary<string, Person>();
        this.databaseOrderedByDomain = new Dictionary<string, SortedSet<Person>>();
        this.databaseOrderedByNameAndTown = new Dictionary<string, SortedSet<Person>>();
        this.databaseOrderedByAgeAndEmail = new OrderedDictionary<int, SortedSet<Person>>();
        this.databaseOrderedByAgeTownAndEmail = new Dictionary<string, OrderedDictionary<int, SortedSet<Person>>>();
    }

    public bool AddPerson(string email, string name, int age, string town)
    {
        if (this.personDatabase.ContainsKey(email))
        {
            return false;
        }

        var newPerson = new Person(email, name, age, town);
        var domain = this.GetDomain(email);
        var nameTown = name + "|" + town;

        this.personDatabase.Add(email, newPerson);
        this.databaseOrderedByDomain.EnsureKeyExists(domain);
        this.databaseOrderedByDomain[domain].Add(newPerson);
        this.databaseOrderedByNameAndTown.EnsureKeyExists(nameTown);
        this.databaseOrderedByNameAndTown[nameTown].Add(newPerson);
        this.databaseOrderedByAgeAndEmail.EnsureKeyExists(age);
        this.databaseOrderedByAgeAndEmail[age].Add(newPerson);
        this.databaseOrderedByAgeTownAndEmail.EnsureKeyExists(town);
        this.databaseOrderedByAgeTownAndEmail[town].EnsureKeyExists(age);
        this.databaseOrderedByAgeTownAndEmail[town][age].Add(newPerson);

        //this.AddByDomain(newPerson);
        //this.AddByNameTown(newPerson);
        //this.AddByAge(newPerson);
        //this.AddByAgeTown(newPerson);

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
        if (!this.personDatabase.ContainsKey(email))
        {
            return null;
        }

        return this.personDatabase[email];
    }

    public bool DeletePerson(string email)
    {
        if (!this.personDatabase.ContainsKey(email))
        {
            return false;
        }

        var personToDelete = this.personDatabase[email];
        var personDomain = this.GetDomain(personToDelete.Email);
        string nameTown = personToDelete.Name + "|" + personToDelete.Town;

        //Delete from main database
        this.personDatabase.Remove(email);

        //Remove from orderedByDomain
        this.databaseOrderedByDomain[personDomain].Remove(personToDelete);

        //Remove from orderedByNameAndTown
        this.databaseOrderedByNameAndTown[nameTown].Remove(personToDelete);

        if (this.databaseOrderedByNameAndTown[nameTown] == null)
        {
            this.databaseOrderedByNameAndTown.Remove(nameTown);
        }

        //Remove from orderedByAgeAndEmail
        this.databaseOrderedByAgeAndEmail[personToDelete.Age].Remove(personToDelete);
        if(this.databaseOrderedByAgeAndEmail[personToDelete.Age] == null)
        {
            this.databaseOrderedByAgeAndEmail.Remove(personToDelete.Age);
        }

        //Remove from OrderedByAgeTownAndEmail
        this.databaseOrderedByAgeTownAndEmail[personToDelete.Town][personToDelete.Age].Remove(personToDelete);
        if (this.databaseOrderedByAgeTownAndEmail[personToDelete.Town][personToDelete.Age] == null)
        {
            this.databaseOrderedByAgeTownAndEmail[personToDelete.Town].Remove(personToDelete.Age);
        }

        if (this.databaseOrderedByAgeTownAndEmail[personToDelete.Town] == null)
        {
            this.databaseOrderedByAgeTownAndEmail.Remove(personToDelete.Town);
        }

        return true;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        if (!this.databaseOrderedByDomain.ContainsKey(emailDomain))
        {
            yield break; 
        }

        foreach(var person in this.databaseOrderedByDomain[emailDomain])
        {
            yield return person;
        }
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        var result = new List<Person>();
        string nameTown = name + "|" + town;

        if (!this.databaseOrderedByNameAndTown.ContainsKey(nameTown))
        {
            yield break;
        }

        foreach (var person in this.databaseOrderedByNameAndTown[nameTown])
        {
            yield return person;
        }
    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        foreach (var peopleByEmail in this.databaseOrderedByAgeAndEmail.Range(startAge, true, endAge, true))
        {
            foreach (var person in peopleByEmail.Value)
            {
                yield return person;
            }
        }
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        if (!databaseOrderedByAgeTownAndEmail.ContainsKey(town))
        {
            yield break;
        }

        foreach (var peopleByAge in this.databaseOrderedByAgeTownAndEmail[town].Range(startAge, true, endAge, true))
        {
            foreach (var person in peopleByAge.Value)
            {
                yield return person;
            }
        }
    }

    private string GetDomain(string email)
    {
        int domainStartIndex = 0;

        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] == '@')
            {
                domainStartIndex = i + 1;
                break;
            }
        }

        if (domainStartIndex == 0)
        {
            throw new ArgumentException("Invalid domain");
        }

        return email.Substring(domainStartIndex); ;
    }

    #region Unused methods
    //private void AddByDomain(Person newPerson)
    //{
    //    string domain = this.GetDomain(newPerson.Email);

    //    if (!this.databaseOrderedByDomain.ContainsKey(domain))
    //    {
    //        this.databaseOrderedByDomain.Add(domain, new SortedSet<Person>());
    //    }

    //    this.databaseOrderedByDomain[domain].Add(newPerson);
    //}

    //private void AddByNameTown(Person newPerson)
    //{
    //    string nameTown = newPerson.Name + "|" + newPerson.Town;

    //    if (!this.databaseOrderedByNameAndTown.ContainsKey(nameTown))
    //    {
    //        this.databaseOrderedByNameAndTown.Add(nameTown, new SortedSet<Person>());
    //    }

    //    this.databaseOrderedByNameAndTown[nameTown].Add(newPerson);
    //}

    //private void AddByAge(Person newPerson)
    //{

    //    if (!this.databaseOrderedByAgeAndEmail.ContainsKey(newPerson.Age))
    //    {
    //        this.databaseOrderedByAgeAndEmail.Add(newPerson.Age, new SortedSet<Person>());
    //    }

    //    this.databaseOrderedByAgeAndEmail[newPerson.Age].Add(newPerson);
    //}

    //private void AddByAgeTown(Person newPerson)
    //{
    //    if (!this.databaseOrderedByAgeTownAndEmail.ContainsKey(newPerson.Town))
    //    {
    //        this.databaseOrderedByAgeTownAndEmail.Add(newPerson.Town, new OrderedDictionary<int, SortedSet<Person>>());
    //    }

    //    if (!databaseOrderedByAgeTownAndEmail[newPerson.Town].ContainsKey(newPerson.Age))
    //    {
    //        this.databaseOrderedByAgeTownAndEmail[newPerson.Town].Add(newPerson.Age, new SortedSet<Person>());
    //    }

    //    this.databaseOrderedByAgeTownAndEmail[newPerson.Town][newPerson.Age].Add(newPerson);
    //}
    #endregion
}
