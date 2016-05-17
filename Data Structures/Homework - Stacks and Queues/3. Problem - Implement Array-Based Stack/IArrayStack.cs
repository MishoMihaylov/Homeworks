interface IArrayStack<T>
{
    int Count { get; }
    int Capacity { get; }
    void Push(T element);
    T Pop();
    T[] ToArray();
}