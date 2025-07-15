using System.Collections.Generic;


List<string> sehirler = new List<string>();
List<int> sehirler1 = new List<int>();

sehirler.Add("İstanbul");
sehirler.Add("İstanbul");
sehirler.Add("İstanbul");
sehirler.Add("İstanbul");
sehirler.Add("İstanbul");
sehirler.Add("İstanbul");
sehirler.Add("İstanbul");
sehirler1.Add(34);
sehirler1.Add(34);
sehirler1.Add(34);
sehirler1.Add(34);
Console.WriteLine(sehirler.Count);
Console.WriteLine(sehirler1.Count);

MyList<string> sehirler2 = new MyList<string>();

sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
Console.WriteLine(sehirler2.Count);

class MyList<T> // Generic class definition
{
    T[] _array;
    T[] _temparray;
    public MyList()
    {
        _array = new T[0]; // Initialize with an empty array
    }


    public void Add(T item)
    {
        _temparray = _array; // Store the current array in a temporary variable
        _array = new T[_array.Length + 1]; // Create a new array with one more element
       for (int i = 0; i < _temparray.Length; i++)
        {
            _array[i] = _temparray[i]; // Copy elements from the temporary array to the new array
        }
        _array[_array.Length - 1] = item; // Add the new item to the end of the array

    }


    public int Count=> _array.Length;

}