class ModernCoffeeTable : ICoffeeTable
{
    public ModernCoffeeTable()
    {
        Console.WriteLine("Modern kofe masasi");
    }
    public bool CanOpen() => true;

    public bool CanRotate() => false;
}
