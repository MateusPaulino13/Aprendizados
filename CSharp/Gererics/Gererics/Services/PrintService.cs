﻿using System.Resources;

namespace Gererics.Services;

public class PrintService<T>
{
    private T[] _values = new T[10];
    private int _count = 0;

    public void AddValue(T value)
    {
        if(_count == 10)    
            throw new InvalidOperationException("Cannot add more than 10 values.");
        
        _values[_count] = value;
        _count++;
    }

    public T First()
    {
        return _count == 0 ? throw new InvalidOperationException("Print is empty"): _values[0];
    }

    public void Print()
    {
        Console.Write("[");

        for (int i = 0; i < _count - 1; i++)
            Console.Write($"{_values[i]}, ");

        if (_count > 0)
            Console.Write(_values[_count - 1]);
        
        Console.Write("]");
        Console.WriteLine();
    }
}