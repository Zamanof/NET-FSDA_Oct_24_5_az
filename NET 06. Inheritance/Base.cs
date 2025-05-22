// Inheritance - toreme (OOP-nin 4 prinsipinden biri)
// Derived class-in (child, subclass, toreyen class) Base class-in(parent, super, toreden class)
// hesabina funksionalliqinin genishlindirilmesine deyilir.

// sealed (mohurlenmish) - bu achar sozu ile elan olunan class-dan toremek mumkun deyil
class Base
{
    public int Field1 { get; set; }
    private int Field2;

    public Base(int field1, int field2)
    {
        Field1 = field1;
        Field2 = field2;
        Console.WriteLine("Base Class Parametrized Constructor");
    }

    public Base()
        :this(5, 78)
    {
        Console.WriteLine("Base Class Default Constructor");
    }

    public void Show() 
        => Console.WriteLine($"Base Show() Field1 = {Field1}, Field2 = {Field2}");

    public void Foo()
    {
        Console.WriteLine("Protected method Foo()");
        Bar();
    }

    private void Bar()
    {
        Console.WriteLine("Private method Bar()");
    }
}