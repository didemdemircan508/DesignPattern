// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");

class ObjectPool<T>
{ 
    readonly ConcurrentBag<T> _instances;

    public ObjectPool()
    {
        _instances = new();
    }


}


class X
{ 

    public int Count { get; set; }

    public void Write() => Console.WriteLine(Count);

    public X() => Console.WriteLine("X üretim maliyeti");


    ~X() => Console.WriteLine("X imha maliyeti");





}
