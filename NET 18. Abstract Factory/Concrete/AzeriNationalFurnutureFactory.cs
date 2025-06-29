class AzeriNationalFurnutureFactory : IFurnutureFactory
{
    public IChair CreateChair() => new AzeriNationalChair();

    public ICoffeeTable CreateCofeeTable() => new AzeriNationalCoffeeTable();

    public ISofa CreateSofa() => new AzeriNationalSofa();
}
