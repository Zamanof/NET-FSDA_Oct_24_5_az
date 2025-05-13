int[] arr = new int[20];
//Random random = new Random();
Random random = new();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(10, 99);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

// ranges - introducing C# 8
// python - lst[2:9] sliceing

//int[] arr2 = arr[2..9];

//foreach (var item in arr2)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

// indcies - introducing C# 8
// python - lst[-1] - negative indexes

Console.WriteLine(arr[^1]);
Console.WriteLine(arr[^2]);

int[] arr3 = arr[2..^3];

foreach (var item in arr3)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

