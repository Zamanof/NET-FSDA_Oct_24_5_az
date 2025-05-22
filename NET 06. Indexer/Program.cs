// Indexer - indeksator
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
// class ve ya struktur instanse-nin(obyektinin, numunesinin) ozunu massiv(array) kimi aparmasi 

// public return_type this[params]{get; set;}

// => lambda operator  - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator

//Garage garage = new Garage(7);
//garage[0] = new Car { Model = "Toyota", Price = 23942 };
//garage[1] = new Car { Model = "BMW", Price = 98723 };
//garage[2] = new Car { Model = "Mercedes", Price = 10000 };
//garage[3] = new Car { Model = "Audi", Price = 15643 };
//garage[4] = new Car { Model = "Lexus", Price = 20000 };
//garage[5] = new Car { Model = "Nissan", Price = 239420 };
//garage[6] = new Car { Model = "Hyundai", Price = 123942 };

//Console.WriteLine(garage["Audi"]);

MultiArray multiArray = new(3, 3);
Random random = new();

for (int i = 0; i < multiArray.Rows; i++)
{
	for (int j = 0; j < multiArray.Columns; j++)
	{
		multiArray[i, j] = random.Next(10, 99);
	}
}


for (int i = 0; i < multiArray.Rows; i++)
{
    for (int j = 0; j < multiArray.Columns; j++)
    {
        Console.Write($"{multiArray[i, j]} ");
    }
    Console.WriteLine();
}
