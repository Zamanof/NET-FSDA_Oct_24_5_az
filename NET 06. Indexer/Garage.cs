// Indexer - indeksator
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
// class ve ya struktur instanse-nin(obyektinin, numunesinin) ozunu massiv(array) kimi aparmasi 

// public return_type this[params]{get; set;}

// => lambda operator  - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator

class Garage
{
    private Car[] cars;

    public Garage(int count)
    {
        cars = new Car[count];
    }

    public int Count
    {
        get => cars.Length;
    }

    // indexer -> with int parameter
    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }

        set
        {
            if (index >= 0 && index < cars.Length)
            {
                cars[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    // indexer -> with string parameter
    public Car this[string model]
    {
        get
        {
            if (Enum.IsDefined(typeof(Models), model))
            {
                return cars[(int)Enum.Parse(typeof(Models), model)];
            }
            return new Car();
        }
        set
        {
            cars[(int)Enum.Parse(typeof(Models), model)] = value;
        }
    }

}