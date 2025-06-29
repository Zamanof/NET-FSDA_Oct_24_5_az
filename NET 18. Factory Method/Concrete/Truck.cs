class Truck : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Deliver {productName} by land in box");
    }
}
