// C# Generic <=> C++ template
/*
- Class
- Struct
- Method
- Interface
- Delegate
- Collections 
*/

//Some<string> some = new();
////some.Foo();
//some.Bar("Salam", 29.3);

Some<List<int>> some = new();

some.Foo();

class Some<T> where T: class, IEnumerable<int>, new()
{
    public T Property { get; set; }
    public void Foo()
    {
        Console.WriteLine(Property.GetType());
    }
    public T2 Bar<T2, T3>(T2 value1, T3 value2)
    {
        Console.WriteLine(value1.GetType());
        Console.WriteLine(value2.GetType());
        return value1;
    }
}

