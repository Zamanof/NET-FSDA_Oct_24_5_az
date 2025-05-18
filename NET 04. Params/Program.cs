// Params - method-a "sonsuz" sayda parametrlerin gonderilmesi
int[] arr = [25, 369, 85, 23, 311, 3, -5];
Console.WriteLine(Summ(arr));
Console.WriteLine(Summ(new int[] { 25, 369, 85, 23, 311, 3, -5 }));
Console.WriteLine(Summ([ 25, 369, 85, 23, 311, 3, -5 ]));
Console.WriteLine(ParamsSum(25, 369, 85, 23, 311, 3, -5));
Console.WriteLine(ParamsSum(25, 369, 85, 23, 311, 3, -5, 98, 782, 126, 789));
Console.WriteLine(ParamsSum(arr));

int Summ(int[] ints)
{
    int result = default;
    foreach (int i in ints)
    {
        result += i;
    }
    return result;
}

int ParamsSum(params int[] ints)
{
    int result = default;
    foreach (int i in ints)
    {
        result += i;
    }
    return result;
}
