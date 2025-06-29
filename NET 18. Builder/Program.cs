// Builder pattern

// Product
// Bulder
// Builder: Concrete
// Director

IBuilder builder = new StoneBuilder();

//var stoneHouse = builder
//                        .BuildWindow()
//                        .BuildGarden()
//                        .BuildWindow()
//                        .BuildRoof()
//                        .BuildWindow()
//                        .BuildGarage()
//                        .GetHouse();
//Console.WriteLine(stoneHouse);

Master master = new(builder);
var house = master.Make("B");
Console.WriteLine(house);
master.ChangeBuilder(new IceBuilder());
house = master.Make("A");
Console.WriteLine(house);

