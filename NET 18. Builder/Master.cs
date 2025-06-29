// Builder pattern

// Product
// Bulder
// Builder: Concrete
// Director




class Master // Director
{
    private IBuilder _builder;

    public Master(IBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IBuilder builder) => _builder = builder;

    public House Make(string type)
    {
        _builder.Reset();
        switch (type)
        {
            case "A":
                _builder.House.Name = "A type House";
                return _builder
                    .BuildWall()
                    .BuildWall()
                    .BuildWall()
                    .BuildWall()
                    .BuildDoor()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildRoof()
                    .GetHouse();
            case "B":
                _builder.House.Name = "B type House";

                return _builder
                    .BuildWall()
                    .BuildWall()
                    .BuildWall()
                    .BuildWall()
                    .BuildDoor()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildGarage()
                    .BuildGarden()
                    .BuildRoof()
                    .GetHouse();
            case "C":
                _builder.House.Name = "C type House";

                return _builder
                    .BuildWall()
                    .BuildWall()
                    .BuildWall()
                    .BuildWall()
                    .BuildDoor()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildWindow()
                    .BuildPool()
                    .BuildGarden()
                    .BuildRoof()
                    .GetHouse();
            default:
                throw new Exception("Wrong House type");
        }
    }
}
