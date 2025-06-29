using System.Threading.Channels;

class AzeriNationalSofa : ISofa
{
    public AzeriNationalSofa()
    {
        Console.WriteLine("Azerbaycan milli divani");
    }
    public bool CanOpen() => true;

    public bool HasCorner() => true;
}
