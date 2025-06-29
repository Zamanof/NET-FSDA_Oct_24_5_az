class ModernChair : IChair
{
    public ModernChair()
    {
        Console.WriteLine("Modern kreslo");
    }
    public bool HasLegs() => false;

    public bool SitOn() => true;
}
