using System;

public class LinkedStack<T> : ILinkedStack<T>
{
    private Node<T> firstNode;
    private Node<T> lastNode;

    public LinkedStack()
    {
        this.Count = 0;
        this.firstNode = null;
        this.lastNode = null;
    }

    public int Count
    {
        get;
        private set;
    }

    public void Push(T element)
    {
        if(this.Count == 0)
        {
            this.firstNode = new Node<T>(element);
            this.lastNode = firstNode;
        }
        else
        {
            Node<T> nextNode = new Node<T>(element);
            this.lastNode.NextNode = nextNode;
            this.lastNode = nextNode;
        }
        this.Count++;
    }

    public T Pop()
    {
        if(this.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        Node<T> currentNode = this.firstNode;
        Node<T> prevNode = this.firstNode;
        T elementToBeReturned = default(T);

        while (true)
        {
            if(currentNode.NextNode == null)
            {
                elementToBeReturned = currentNode.value;
                prevNode.NextNode = null;
                break;
            }

            prevNode = currentNode;
            currentNode = currentNode.NextNode;
        }

        this.Count--;
        return elementToBeReturned;
    }

    public T[] ToArray()
    {
        T[] array = new T[this.Count];
        Node<T> currentNode = this.firstNode;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            array[i] = currentNode.value;
            currentNode = currentNode.NextNode;
        }

        return array;
    }

    private class Node<T>
    {
        public T value;
        public Node<T> NextNode { get; set; }

        public Node(T value, Node<T> nextNode = null)
        {
            this.value = value;
            this.NextNode = nextNode;
        }
    }

}