using System.Resources;

namespace Gererics;

public class PrintService
{
    private int[] _values = new int[10];
    private int _count = 0;

    public void AddValue(int value)
    {
        if(_count == 10)    
            throw new InvalidOperationException("Cannot add more than 10 values.");
        
        _values[_count] = value;
        _count++;
    }

    public int First()
    {
        return (_count == 0) ? throw new InvalidOperationException("Print is empty"): _values[0];
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