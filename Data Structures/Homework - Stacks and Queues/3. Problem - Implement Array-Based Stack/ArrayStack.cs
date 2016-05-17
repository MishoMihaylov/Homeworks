using System;

public class ArrayStack<T> : IArrayStack<T>
{
    private const int InitialCapacity = 16;
    private T[] elements;

    public ArrayStack(int capacity = InitialCapacity)
    {
        this.elements = new T[capacity];
        this.Count = 0;
    }

    public int Count
    {
        get;
        private set;
    }

    public int Capacity
    {
        get
        {
            return this.elements.Length;
        }
    }

    public void Push(T element)
    {
        if (this.Count == this.Capacity)
        {
            Grow();
        }

        elements[this.Count] = element;

        this.Count++;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty!");
        }

        this.Count--;
        T elementToBeReturned = this.elements[this.Count];
        this.elements[this.Count] = default(T);

        return elementToBeReturned;
    }

    public T[] ToArray()
    {
        T[] arrayToBeReturned = new T[this.Count];
        for (int i = 0, j = this.Count - 1; i < this.Count; i++, j--)
        {
            arrayToBeReturned[i] = elements[j];
        }

        return arrayToBeReturned;
    }

    private void Grow()
    {
        T[] newArray = new T[this.Capacity * 2];
        Array.Copy(elements, newArray, this.Count);
        elements = newArray;
    }
}