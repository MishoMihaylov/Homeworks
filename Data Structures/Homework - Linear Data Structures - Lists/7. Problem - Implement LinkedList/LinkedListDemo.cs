using System;

class LinkedListDemo
{
    static void Main(string[] args)
    {
        CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();

        customLinkedList.Add(5);
        customLinkedList.Add(4);
        customLinkedList.Add(2);
        customLinkedList.Add(3);
        customLinkedList.Add(4);
        customLinkedList.Add(5);

        Console.WriteLine(customLinkedList.Count);
        Console.WriteLine(customLinkedList.FirstIndexOf(4));
        Console.WriteLine(customLinkedList.LastIndexOf(4));
        customLinkedList.Remove(0);
        customLinkedList.Remove(customLinkedList.Count - 1);
        customLinkedList.Remove(1);

        Console.WriteLine();

        for (int i = 0; i < customLinkedList.Count; i++)
        {
            Console.WriteLine(customLinkedList[i]);
        }

        Console.WriteLine();

        foreach(var item in customLinkedList)
        {
            Console.WriteLine(item);
        }
    }
}