using System;
using System.Collections.Generic;

class BiDictionary<K1, K2, T>
{
    private Dictionary<K1, List<T>> valuesByFirstKey;
    private Dictionary<K2, List<T>> valuesBySecondKey;
    private Dictionary<Tuple<K1, K2>, List<T>> valuesByBothKeys;

    public BiDictionary()
    {
        this.valuesByFirstKey = new Dictionary<K1, List<T>>();
        this.valuesBySecondKey = new Dictionary<K2, List<T>>();
        this.valuesByBothKeys = new Dictionary<Tuple<K1, K2>, List<T>>();
    }

    public void Add(K1 key1, K2 key2, T value)
    {
        var currentTuple = new Tuple<K1, K2>(key1, key2);

        if (!this.valuesByFirstKey.ContainsKey(key1))
        {
            this.valuesByFirstKey.Add(key1, new List<T>());
        }

        if (!this.valuesBySecondKey.ContainsKey(key2))
        {
            this.valuesBySecondKey.Add(key2, new List<T>());
        }

        if (!this.valuesByBothKeys.ContainsKey(currentTuple))
        {
            this.valuesByBothKeys.Add(currentTuple, new List<T>());
        }

        this.valuesByFirstKey[key1].Add(value);
        this.valuesBySecondKey[key2].Add(value);
        this.valuesByBothKeys[currentTuple].Add(value);
    }

    public IEnumerable<T> Find(K1 key1, K2 key2)
    {
        var currentTuple = new Tuple<K1, K2>(key1, key2);

        if (!this.valuesByBothKeys.ContainsKey(currentTuple))
        {
            yield break; 
        }

        foreach (var item in this.valuesByBothKeys[new Tuple<K1, K2>(key1, key2)])
        {
            yield return item;
        }
    }

    public IEnumerable<T> FindByKey1(K1 key1)
    {
        IEnumerable<T> items = new List<T>();

        if (!this.valuesByFirstKey.ContainsKey(key1))
        {
            yield break;
        }

        foreach (var item in valuesByFirstKey[key1])
        {
            yield return item;
        }
    }

    public IEnumerable<T> FindByKey2(K2 key2)
    {
        if (!this.valuesBySecondKey.ContainsKey(key2))
        {
            yield break;
        }

        foreach (var item in valuesBySecondKey[key2])
        {
            yield return item;
        }
    }

    public bool Remove(K1 key1, K2 key2)
    {
        var currentTuple = new Tuple<K1, K2>(key1, key2);

        if (!this.valuesByBothKeys.ContainsKey(currentTuple))
        {
            return false;
        }

        foreach (var value in valuesByBothKeys[currentTuple])
        {
            this.valuesByFirstKey[key1].Remove(value);
            this.valuesBySecondKey[key2].Remove(value);
        }

        this.valuesByBothKeys.Remove(currentTuple);

        return true;
    }
}
