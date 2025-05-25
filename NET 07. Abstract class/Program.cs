
// Abstract classes
// is elaqesidir - Mensubiyyet bildirir
// (Student is Human, Car is Transport, CheshireCat is Cat is Animal)

#region Abstract classes introduction

//Some some = new();
//Other other = new();

//other.SomeMethod();
//abstract class Some
//{
//    public int SomeIntField;
//    public string SomeStringProperty { get; set; }

//    public virtual void SomeMethod()
//    {
//        Console.WriteLine("Some Method");
//    }

//    public abstract void SomeAbstractMethod();
//}

//abstract class Other : Some
//{
//    //public override void SomeAbstractMethod()
//    //{
//    //    Console.WriteLine("Other class SomeAbstractMethod() implementation");
//    //}
//}
#endregion

Pikachu pikachu = new("Pikadillo");
Charmander charmander = new("Charman");

Pokemon[] pokemons = [pikachu, charmander, new Pikachu("Almdolaqi")];
Fire[] fires = [
    charmander,
    new Charmander("Ascii"),
    new Charmander("Unicode")
    ];

//foreach(Pokemon pokemon in pokemons)
//{
//    pokemon.Sound();
//}

//Fight(pikachu, charmander);
//FirePokemonsGym(charmander);
//Console.WriteLine(charmander.Level);

Pokedex pokedex = new Pokedex();
pokedex.Add(pikachu);
pokedex.Add(charmander);
pokedex.Add(new Charmander("Salat"));

pokedex.GetAllPokemons();

void Fight(Pokemon left, Pokemon right)
{
    left.Attack();
    right.Attack();
}

void FirePokemonsGym(Fire fire)
{
    fire.LevelUp();
}

(pokemons[0] as Pikachu)?.SpecialElectricAttack();
class Pokedex
{
    private List<Pokemon> Pokemons {  get; set; } = new List<Pokemon>();

    public void GetAllPokemons()
    {
        foreach (var item in Pokemons)
        {
            Console.WriteLine(item.Name);
        }
    }

    public void Add(Pokemon pokemon)
    {
        Pokemons.Add(pokemon);
    }
}