using System.Collections.Generic;

interface IReversedList<T> : IEnumerable<T>
{
    int Count { get; }

    int Capacity { get; }

    void Add(T Element);

    void Remove(int index);

    T this[int index] { get; set; }
}
