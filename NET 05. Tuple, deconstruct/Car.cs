// Deconstruct
class Car
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }

    public Car(string model, string manufacturer, int year)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
    }

    // Deconstruct
    // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct

    public void Deconstruct(out string model, out string manufacturer, out int year)
    {
        model = Model;
        manufacturer = Manufacturer;
        year = Year;
    }

    public override string ToString()
    {
        return $"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}";
    }
}
