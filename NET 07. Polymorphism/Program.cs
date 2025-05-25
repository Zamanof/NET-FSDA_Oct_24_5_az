Base @base = new();
Derived derived = new Derived();

//@base.Show();
//derived.Show();

// Reference to Base class
Base obj = new Derived(); // upcast
//obj.Show();
//((Derived)obj).Show(); // downcast

Base[] arr = [@base, derived, new Child()];

foreach (Base b in arr)
{
    b.Show();
    (b as Derived)?.Print();
}

//Foo(@base);
//Foo(derived);
//Foo(new Child());

void Foo(Base @base)
{

    #region version1
    //if (@base.GetType() == new Derived().GetType())
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base.GetType() == new Child().GetType())
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version2
    //try
    //{
    //    ((Derived)@base).Show();
    //}
    //catch (Exception)
    //{ }
    //try
    //{
    //    ((Child)@base).Show();
    //}
    //catch (Exception)
    //{ }
    //try
    //{
    //    @base.Show();
    //}
    //catch (Exception)
    //{ }
    #endregion

    #region version3
    //if (@base is Derived)
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base is Child)
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version4
    //var value = @base is Derived ? (Derived)@base : null; // how as keyword worked
    //if (value != null) value.Show();

    //var value1 = @base as Derived;
    //var value2 = @base as Child;
    //var value3 = @base as Base;
    //if (value1 is not null) value1.Show();
    //else if (value2 is not null) value2.Show();
    //else if (value3 is not null) value3.Show();

    //(@base as Derived)?.Show();
    #endregion

    @base.Show();

}