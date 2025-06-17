// yield return, yield break

var hellos = GetResults();
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);

//while (hellos.MoveNext())
//{
//    Console.WriteLine(hellos.Current);
//}

//foreach(var item in GetValues())
//{
//    Console.WriteLine(item);
//}

string lorem = "orem ipsum dolor sit amet, consectetur adipiscing elit. Sed consectetur interdum ligula, a malesuada quam auctor vel. In porta justo congue malesuada fermentum.";

foreach (var i in MyRange(5, lorem.Length, 3))
{
    Console.Write($"{lorem[i]} ");
}



IEnumerator<string> GetResults()
{
    yield return "Salam";
    yield return "Hi";
    yield return "Hello";
    yield return "Ola";
    yield return "Salam Aleykum";
    yield return "Aloha";
}
IEnumerable<string> GetValues()
{
    List<string> strings = ["Saqol", "Bye", "Goodye", "Elvida", "Aloha", "Salam Aleykum"];

    for (int i = 0; i < strings.Count; i++)
    {
        yield return strings[i].ToUpper();
    }
}

IEnumerable<int> MyRange(int start, int? end = null, int steps = 1)
{
    if (start > end && steps > 0) yield break;
    if (end is null)
    {
        end = start;
        start = 0;
    }
    for (int i = start; i < end; i+= steps)
    {
        yield return i;
    }
}