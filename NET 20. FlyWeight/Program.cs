// FlyWeight

List<UnitFlyWeight> units = new();
FlyWeightFactory factory = new();
for (int i = 0; i < 1000000; i++)
{
    //Archer archer = new Archer();
    //Warrior warrior = new Warrior();


    UnitFlyWeight archer =  factory.GetUnit("Archer");
    UnitFlyWeight warrior =  factory.GetUnit("Warrior");

    Console.WriteLine(archer.GetHashCode());
    Console.WriteLine(warrior.GetHashCode());

    units.Add(archer);
    units.Add(warrior);
}
abstract class UnitFlyWeight
{
    protected string Name;
    protected int AttackPoint;
    protected int Health;
    public abstract void Display();
}

class Archer : UnitFlyWeight
{
    public Archer()
    {
        Name = "Archer";
        AttackPoint = 120;
        Health = 70;
    }

    public override void Display()
    {
        Console.WriteLine("Archer created");
    }
}

class Warrior : UnitFlyWeight
{
    public Warrior()
    {
        Name = "Warrior";
        AttackPoint = 120;
        Health = 70;
    }

    public override void Display()
    {
        Console.WriteLine("Warrior created");
    }
}

class FlyWeightFactory
{
    private Dictionary<string, UnitFlyWeight> _units = new();

    public UnitFlyWeight GetUnit(string key)
    {
        UnitFlyWeight unit = default;

        if (_units.ContainsKey(key))
        {
            unit = _units[key];
        }
        else
        {
            switch (key)
            {
                case "Archer":
                    unit = new Archer();
                    break;
                case "Warrior":
                    unit = new Warrior();
                    break;
            }
            _units.Add(key, unit);
        }
        return unit;
    }
}