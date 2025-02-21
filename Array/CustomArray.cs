using System;
using System.Collections;

namespace Array;

public class CustomArray<T> : IEnumerable<T>
{
    private static readonly T _default = default!;

    /// <summary>
    /// An array of items to store value
    /// </summary>
    private T[] _items;

    /// <summary>
    /// A _current to keep track of the index of the lasted item added
    /// </summary>
    private int _current;

    /// <summary>
    /// A Count to keep track of the actual number of items in the list
    /// </summary>
    public int Count => _current;

    /// <summary>
    /// The length of the array
    /// </summary>
    public int Length => _items.Length;

    /// <summary>
    /// Constructor - Initialize an array with the default length to be 4
    /// </summary>
    /// <param name="Length"></param>
    public CustomArray(int Length = 4)
    {
        _items = new T[Length];
        _current = 0;
    }

    /// <summary>
    /// Add a new item to the array
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
        // if the array is full
        if (_current == _items.Length)
        {
            // Double the capacity of array
            Resize(_items.Length * 2);
        }

        // update the value of the item at the new last index
        _items[_current++] = item;
    }

    /// <summary>
    /// Remove an item at the given index
    /// </summary>
    /// <param name="index"></param>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public void Remove(int index)
    {
        // if index is less than 0 or larger than the index of the current last item
        if (index < 0 || index >= _current)
        {
            throw new IndexOutOfRangeException();
        }

        // loop from the given index to the index of th last item in the list
        for (int i = index; i < _current - 1; i++)
        {
            // shifting the list of element to the left
            _items[i] = _items[i + 1];
        }

        // decrease the number of items and set the previous last item to be null/default
        _items[--_current] = _default;
    }

    /// <summary>
    /// Resize the capacity of the array - doubled by default 
    /// </summary>
    /// <param name="newLength">The new capacity for the array</param>
    public void Resize(int newLength)
    {
        // create a new array with the new capacity
        T[] _copy = new T[newLength];

        // copy _current items from the initial array to the new array
        System.Array.Copy(_items, _copy, _current);

        _items = _copy;
    }

    /// <summary>
    /// Allow looping through the array of items
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _current; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
