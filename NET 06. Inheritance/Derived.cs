// Inheritance - toreme (OOP-nin 4 prinsipinden biri)
// Derived class-in (child, subclass, toreyen class) Base class-in(parent, super, toreden class)
// hesabina funksionalliqinin genishlindirilmesine deyilir.


class Derived: Base
{
    public string SomeProperty { get; set; }
    public Derived()
        :this(string.Empty, 0, 0)
    {
        Console.WriteLine("Derived class Default Constructor");
    }

    public Derived(string someProperty, int field1, int field2)
        :base(field1, field2)
    {
        SomeProperty = someProperty;
        Console.WriteLine("Derived class Parametrized Constructor");
    }

    public void DerivedFoo()
    {
        Foo();
    }
    // new -> method hidding - Base class-da olan methodla Derived class-da eyni adda method varsa
    // ve bu override deyilse bu zaman new achar sozu yazmaq lazimdir
    // yeni base class-da olan methodu gizledirik
    public new void Foo()
    {
        Console.WriteLine("Derived class Foo method");
    }


}