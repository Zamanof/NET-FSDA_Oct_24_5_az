// class
Human human = new Human("Nadir", "Zamanov", 45);
Human human1 = new("Salam", "Salamzade", 25);
////human.Show();

////Console.WriteLine(human.Info());

//Console.WriteLine(human);
//Console.WriteLine(human1);

Human human2 = new();
//Console.WriteLine(human2);

Human human3 = new Human(name: "Abdullah", age: 36, surname: "Allahverdiyev");

Human human4 = new Human
{
    name = "Ali",
    surname = "Aliyev",
    age = 30
};

//Console.WriteLine(human3);
//Console.WriteLine(human4);
//Console.WriteLine(Human.count);
//Human.count = 25;
//Console.WriteLine(Human.count);
//Console.WriteLine(Human.field1);
////Human.field1 = 25;
//Console.WriteLine(human4.field2);

Dog dog = new Dog("Toplan", 2, 36.5f);
Console.WriteLine(dog.some);
Console.WriteLine(dog);