using System;
using System.Collections;
using System.Collections.Generic;

class CustomLinkedList<T> : ICustomLinkedList<T>
{
    private class ListNode
    {
        public T value;
        public ListNode nextElement;

        public ListNode(T value, ListNode prevElement)
        {
            this.value = value;
            prevElement.nextElement = this;
            nextElement = null;
        }

        public ListNode(T value)
        {
            this.value = value;
            this.nextElement = null;
        }
    }

    private ListNode head;
    private ListNode tail;

    public CustomLinkedList()
    {
        this.Count = 0;
    }

    public int Count
    {
        get;
        private set;
    }

    public void Add(T element)
    {
        if(this.head == null)
        {
            this.head = new ListNode(element);
            this.tail = this.head;
        }
        else
        {
            ListNode lastAddedElement = new ListNode(element, this.tail);
            this.tail = lastAddedElement;
        }

        this.Count++;
    }

    public int FirstIndexOf(T item)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public int LastIndexOf(T item)
    {
        ListNode currentNode = head;
        int index = -1;

        for (int i = 0; i < this.Count; i++)
        {
            if (this[i].Equals(item))
            {
                index = i;
            }
        }

        return index;
    }

    public void Remove(int index)
    {
        ListNode currentNode = head;
        ListNode prevNode = null;
        int i = 0;

        if (this.Count == 1)
        {
            this.head = null;
            this.tail = null;
        }
        else
        {
            while (currentNode != null)
            {
                if (i == index)
                {
                    if (index == this.Count - 1)
                    {
                        prevNode.nextElement = null;
                        this.tail = prevNode;
                    }
                    else if (index == 0)
                    {
                        this.head = currentNode.nextElement;
                    }
                    else
                    {
                        prevNode.nextElement = currentNode.nextElement;
                    }

                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.nextElement;
                i++;
            }
        }
        this.Count--;
    }

    public IEnumerator<T> GetEnumerator()
    {
        ListNode currentNode = head;

        while (currentNode != null)
        {
            yield return currentNode.value;

            currentNode = currentNode.nextElement;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public T this[int index]
    {
        get
        {
            ListNode currentNode = head;
            int i = 0;

            while (i != this.Count)
            {
                if (i == index)
                {
                    return currentNode.value;
                }

                currentNode = currentNode.nextElement;
                i++;
            }
            return default(T);
            throw new ArgumentException("Invalid Index");
        }
    }
}
