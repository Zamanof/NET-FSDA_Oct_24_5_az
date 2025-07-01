// Strategy pattern

// Dependency inversion

#region Serializer example

//WorkToFile workToFile = new WorkToFile(new JsonSerialize());
//workToFile.Serialize();
//workToFile.Deserialize();

//Console.WriteLine();

//workToFile.SetSerializaton(new HuseynSerialize());
//workToFile.Serialize();
//workToFile.Deserialize();
//interface ISerialize
//{
//    void Serialize();
//    void Deserialize();
//}
//class JsonSerialize: ISerialize // startegy
//{
//    public void Serialize() => Console.WriteLine("JSON Serialize");
//    public void Deserialize() => Console.WriteLine("JSON Deserialize");
//}

//class XMLSerialize: ISerialize // startegy
//{
//    public void Serialize() => Console.WriteLine("XML Serialize");
//    public void Deserialize() => Console.WriteLine("XML Deserialize");
//}

//class HuseynSerialize : ISerialize // startegy
//{
//    public void Serialize() => Console.WriteLine("Huseyn Style Serialize");
//    public void Deserialize() => Console.WriteLine("Huseyn Style Deserialize");
//}
//class WorkToFile // context
//{
//    private ISerialize _serializer;

//    public WorkToFile(ISerialize serializer)
//    {
//        _serializer = serializer;
//    }

//    public void Serialize()=> _serializer.Serialize();
//    public void Deserialize()=> _serializer.Deserialize();
//    public void SetSerializaton(ISerialize serializer)=> _serializer = serializer;

//}
#endregion


#region SortingExample
List<int> ints = [34, -7, 89, 35, 13, -200, 45, 12];
//ints.Sort();
//ints.ForEach(i => Console.Write($"{i} "));
//Console.WriteLine();

Sorting<int> sorting = new(new BubbleSort());
var lst = sorting.Sort(ints);
lst.ForEach(i => Console.Write($"{i} "));

interface ISorting<T> // // strategy abstraction
{
    List<T> Sort(List<T> collection);
}

class BubbleSort : ISorting<int> // strategy
{
    public List<int> Sort(List<int> collection)
    {
        var n = collection.Count;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (collection[j] > collection[j + 1])
                {
                    var tempVar = collection[j];
                    collection[j] = collection[j + 1];
                    collection[j + 1] = tempVar;
                }
        return collection;
    }
}


class SelectionSorting : ISorting<int> // strategy
{
    public List<int> Sort(List<int> collection)
    {
        var arrayLength = collection.Count;
        for (int i = 0; i < arrayLength - 1; i++)
        {
            var smallestVal = i;
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (collection[j] < collection[smallestVal])
                {
                    smallestVal = j;
                }
            }
            var tempVar = collection[smallestVal];
            collection[smallestVal] = collection[i];
            collection[i] = tempVar;
        }
        return collection;
    }
}

class DefaultSorting : ISorting<int> // strategy
{
    public List<int> Sort(List<int> collection)
    {
        var lst = collection;
        collection.Sort();
        return collection;
    }
}
class Sorting<T> // context
{
    private ISorting<T> _sorting;

    public Sorting(ISorting<T> sorting)
    {
        _sorting = sorting;
    }
    public List<T> Sort(List<T> collection) => _sorting.Sort(collection);
}
#endregion