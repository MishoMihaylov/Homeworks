interface IDoubleLinkedQueue<T>
{
    int Count { get; }

    void Enqueue(T element);

    T Dequeue();

    T[] ToArray();
}
