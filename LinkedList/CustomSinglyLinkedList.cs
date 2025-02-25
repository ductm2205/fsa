using System;

namespace LinkedList;

public class CustomSinglyLinkedList<T>
{
    private Node<T> _head;

    public void Add(T value)
    {
        var newNode = new Node<T>(value);

        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            var current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }
    }

    public void Remove(T item)
    {

        if (_head.Data.Equals(item))
        {
            _head = _head.Next;
            return;
        }

        var current = _head;

        while (current.Next != null && !current.Data.Equals(item))
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
        else
        {
            System.Console.WriteLine("item not found");
        }

    }

    public void Display()
    {
        var current = _head;

        while (current.Next != null)
        {
            System.Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}

internal class Node<T>
{
    public Node(T data = default, Node<T> next = null)
    {
        Data = data;
        Next = next;
    }

    public T Data { get; set; }
    public Node<T> Next { get; set; }
}