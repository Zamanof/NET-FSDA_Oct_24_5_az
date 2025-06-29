class StoneBuilder : IBuilder
{
    public House House { get; set; } = new House { Name = "Stone House" };

    public IBuilder BuildDoor()
    {
        House.Door++;
        return this;
    }

    public IBuilder BuildGarage()
    {
        House.Garage++;
        return this; ;
    }

    public IBuilder BuildGarden()
    {
        House.Garden++;
        return this;
    }

    public IBuilder BuildPool()
    {
        House.Pool++;
        return this;
    }

    public IBuilder BuildRoof()
    {
        House.HasRoof = true;
        return this; 
    }

    public IBuilder BuildWall()
    {
        House.Wall++;
        return this;
    }

    public IBuilder BuildWindow()
    {
        House.Window++;
        return this;
    }

    public House GetHouse()
    {
        Console.WriteLine("Stone House");
        return House;
    }

    public IBuilder Reset()
    {
        House = new();
        return this;
    }
}

