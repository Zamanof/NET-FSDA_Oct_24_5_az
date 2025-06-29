using System.Threading.Channels;

class ModernSofa : ISofa
{
    public ModernSofa()
    {
        Console.WriteLine("Modern divan");
    }
    public bool CanOpen() => false;

    public bool HasCorner() => false;
}
