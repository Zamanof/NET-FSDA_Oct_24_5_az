class AzeriNationalCoffeeTable : ICoffeeTable
{
    public AzeriNationalCoffeeTable()
    {
        Console.WriteLine("Azerbaycan milli chay masasi");
    }
    public bool CanOpen() => false;

    public bool CanRotate() => false;
}
