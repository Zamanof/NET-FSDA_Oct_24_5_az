class ModernFurnutureFactory : IFurnutureFactory
{
    public IChair CreateChair() => new ModernChair();

    public ICoffeeTable CreateCofeeTable() => new ModernCoffeeTable();

    public ISofa CreateSofa() => new ModernSofa();
}
