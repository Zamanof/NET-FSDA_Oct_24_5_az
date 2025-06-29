// Builder pattern

// Product
// Bulder
// Builder: Concrete
// Director
interface IBuilder
{
    public House House { get; set; }
    IBuilder Reset();
    IBuilder BuildWall();
    IBuilder BuildDoor();
    IBuilder BuildWindow();
    IBuilder BuildGarage();
    IBuilder BuildGarden();
    IBuilder BuildPool();
    IBuilder BuildRoof();

    House GetHouse(); // Build
}
