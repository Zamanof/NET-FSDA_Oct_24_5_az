abstract class Pokemon
{
    public string Name { get; set; }
    public int Level { get; set; } = 0;

    protected Pokemon(string name)
    {
        Name = name;
    }

    public abstract void Sound();
    public abstract void Attack();

    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} level up. Level: { Level}");
    }
} 
