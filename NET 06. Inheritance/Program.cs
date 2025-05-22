// Inheritance - toreme (OOP-nin 4 prinsipinden biri)
// Derived class-in (child, subclass, toreyen class) Base class-in(parent, super, toreden class)
// hesabina funksionalliqinin genishlindirilmesine deyilir.


//Base @base = new();
//@base.Show();

//Derived derived = new("Salam", 98, 987);
// BP, DP
//Derived derived2 = new();
// BP, DP, DD

//derived2.DerivedFoo();
// Derived is Base
//Some(derived2);


GrandChild grandChild = new();
// BP, DP , GD
// (GrandChild is Derived) is Base
// Some(grandChild);

grandChild.Foo();

void Some(Base @base)
{
    @base.Show();
}

