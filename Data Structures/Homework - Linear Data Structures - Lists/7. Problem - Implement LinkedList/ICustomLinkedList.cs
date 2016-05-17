using System.Collections.Generic;

interface ICustomLinkedList<T> : IEnumerable<T>
{
    int Count { get; }

    void Add(T element);

    void Remove(int index);

    int FirstIndexOf(T item);

    int LastIndexOf(T item);
}