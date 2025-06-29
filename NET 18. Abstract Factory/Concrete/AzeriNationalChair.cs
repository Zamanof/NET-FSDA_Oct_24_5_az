class AzeriNationalChair : IChair
{
    public AzeriNationalChair()
    {
        Console.WriteLine("Azerbaycan milli kreslosu");
    }
    public bool HasLegs() => true;

    public bool SitOn() => false;
}
