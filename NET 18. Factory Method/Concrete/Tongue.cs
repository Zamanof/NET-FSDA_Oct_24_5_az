internal class Tongue : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Camaat arsinda {productName} xeberini dashiyir");
    }
}