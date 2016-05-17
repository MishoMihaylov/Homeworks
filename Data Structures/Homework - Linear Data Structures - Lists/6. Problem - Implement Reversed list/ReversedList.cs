using System;
using System.Collections;
using System.Collections.Generic;

class ReversedList<T> : IReversedList<T>
{
    private const int DefaultCapacity = 5;
    private T[] storage;

    public ReversedList(int capacity = DefaultCapacity)
    {
        this.Capacity = capacity;
        this.storage = new T[this.Capacity];
        this.Count = 0;
    }

    public int Count
    {
      get;
      private set;
    }

    public int Capacity
    {
        get;
        private set;
    }

    public T this[int index]
    {
        get
        {
            IndexRangeCheck(index);
            return this.storage[index];
        }
        set
        {
            IndexRangeCheck(index);
            this.storage[index] = value;
        }
    }

    public void Add(T element)
    {
        ManageCapacity();
        if(this.Count == 0)
        {
            this.storage[0] = element;
        }
        else
        {
            T[] newArray = new T[this.Capacity];
            Array.Copy(this.storage, 0, newArray, 1, this.Count);
            this.storage = newArray;
            this.storage[0] = element;
        }
        
        this.Count++;
    }

    public void Remove(int index)
    {
        IndexRangeCheck(index);

        for (int i = index; i < this.Count - 1; i++)
        {
            this.storage[i] = this.storage[i + 1];
        }

        this.storage[this.Count - 1] = default(T);
        this.Count--;
    }

    private void ManageCapacity()
    {
        if(this.Count == this.Capacity)
        {
            this.Capacity *= 2;
            T[] newArray = new T[this.Capacity * 2];
            Array.Copy(this.storage, newArray, this.Count);
            this.storage = newArray;
        }
    }

    private void IndexRangeCheck(int index)
    {
        if(Count == 0)
        {
            throw new ArgumentNullException("The list is empty.");
        }

        if(index >= this.Count || index < 0) 
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            yield return this.storage[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}