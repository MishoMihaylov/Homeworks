using System;

public class DoubleLinkedQueue<T> : IDoubleLinkedQueue<T>
{
    private QueueNode<T> queueHead;
    private QueueNode<T> queueTail;

    public DoubleLinkedQueue()
    {
        this.queueHead = null;
        this.queueTail = null;
        this.Count = 0;
    }

    public int Count { get; private set; }

    public void Enqueue(T element)
    {
        if(this.Count == 0)
        {
            this.queueHead = new QueueNode<T>(element);
            this.queueTail = this.queueHead;
        }
        else
        {
            QueueNode<T> newNode = new QueueNode<T>(element, this.queueTail);
            this.queueTail.PrevNode = newNode;
            this.queueTail = newNode;
        }

        this.Count++;
    }

    public T Dequeue()
    {
        if(this.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty!");
        }

        QueueNode<T> prevElement;
        T dequeueElement =  this.queueHead.Value;

        if(this.Count > 1)
        {
            prevElement = this.queueHead.PrevNode;
            prevElement.NextNode = null;
            this.queueHead = prevElement;
        }
        else
        {
            this.queueHead = null;
            this.queueTail = null;
        }

        this.Count--;

        return dequeueElement;
    }

    public T[] ToArray()
    {
        T[] array = new T[this.Count];
        QueueNode<T> currenNode = this.queueHead;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = currenNode.Value;
            currenNode = currenNode.PrevNode;
        }

        return array;
    }

    private class QueueNode<T>
    {
        public T Value { get; private set; }
        public QueueNode<T> NextNode { get; set; }
        public QueueNode<T> PrevNode { get; set; }

        public QueueNode(T value, QueueNode<T> nextNode = null)
        {
            this.Value = value;
            this.NextNode = nextNode;
        }
    }

}
