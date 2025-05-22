// C#-da tiplerin tehlukesizliyine onem verildiyi uchun bir neche class-dan toreme (multiple inheritance) qadaqandir
// Bu da meshur "Dead Diamond" probleminin qarshisini alir
// Class 'class' cannot have multiple base classes: 'class_1' and 'class_2'
// class GrandChild : Derived, Base -> error
class GrandChild : Derived
{
    public GrandChild()
        : base("Hi", 49, 54)
    {
        Console.WriteLine("GrandChild Class Default Constructor");
    }

    public GrandChild(string someProperty, int field1, int field2) 
        : base(someProperty, field1, field2)
    {
        Console.WriteLine("GrandChild Class Parametrized Constructor");
    }
    public void GrandChildFoo()
    {
        Foo();
    }
}

