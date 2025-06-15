// IDisposable
//MyClass my = new MyClass();
//try
//{
//    my.Foo();

//}
//finally
//{
//    my.Dispose();
//}

// using(){} - syntax sugar
//using (MyClass my = new MyClass())
//{
//    my.Foo();
//}

using MyClass my = new MyClass();
my.Foo();
class MyClass : IDisposable
{
    public MyClass()
    {
        Console.WriteLine("Constructor ...");
    }
    private bool _isDisposed = false;
    public void Foo()
    {
        Console.WriteLine("Some Magic operations...");
        throw new Exception();
    }

    private void Cleaning(bool disposing)
    {
        if (!_isDisposed)
        {
            if (disposing)
            {
                Console.WriteLine("Managed resources are cleaned");
            }
            Console.WriteLine("UnManaged resources are cleaned");
            _isDisposed = true;
        }
    }
    public void Dispose()
    {
        Cleaning(true);
        GC.SuppressFinalize(this);
    }

    ~MyClass()
    {
        Cleaning(false);
    }
}
