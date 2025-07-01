// Observer pattern - mushahidechi
// Also known as: Event-Subscriber, Listener

// Subject - Publisher
// Observer - Subscribers

class Employee : Observer // Subscriber
{
    public override void Update(string message)
    {
        Console.WriteLine($"Message to employee: {message}");
    }
}