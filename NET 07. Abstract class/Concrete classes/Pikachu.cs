class Pikachu : Electric
{
    public Pikachu(string name) : base(name)
    {}

    public override void Attack()
    {
        Console.WriteLine($"Pickachu -> {Name} attacked");
    }

    public override void ElectricAttack()
    {
        Console.WriteLine($"Pickachu -> {Name} electric attacked");
    }

    public void SpecialElectricAttack()
    {
        Console.WriteLine($"Pickachu -> {Name} special electric attacked");
    }

    public override void Sound()
    {
        Console.WriteLine("Pika, Pika");
    }
}
