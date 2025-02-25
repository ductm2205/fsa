using System;

namespace LinkedList;

public class DoubleLinkedList<T>
{

    private ListNode<T> _head;
    private ListNode<T> _tail;

    public void Add(T item)
    {
        var listNode = new ListNode<T>(item);

        if (_head == null)
        {
            _head = listNode;
            _tail = listNode;
        }
        else
        {
            var _current = _head;

            while (_current.Next != null)
            {
                _current = _current.Next;
            }

            _current.Next = listNode;
            listNode.Previous = _current.Next;
        }
    }

    public void Display()
    {
        var _current = _head;

        while (_current.Next != null)
        {
            System.Console.WriteLine(_current.Data);
            _current = _current.Next;
        }
    }

}

internal class ListNode<T>(T data = default, ListNode<T> previous = null, ListNode<T> next = null)
{
    public T Data { get; set; } = data;
    public ListNode<T> Previous { get; set; } = previous;
    public ListNode<T> Next { get; set; } = next;
}
