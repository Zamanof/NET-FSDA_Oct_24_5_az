// Arrays

// C++ style arrays

// static array
// int arr[5] = {15, 68, 12, 7, 89};

// dynamic array
// int* arr = new int[5]{15, 68, 12, 7, 89};

// C# arrays
// birolchulu arraylar
//int[] arr = new int[5] { 15, 68, 12, 7, 89 };
//int[] arr1 = { 15, 68, 12, 7, 89 };
//int[] arr2 = [15, 68, 12, 7, 89];
//Console.WriteLine(arr[0]);
//Console.WriteLine(arr.Length);
//Console.WriteLine(arr.Rank);

// choxolchulu (multidimension) array-lar
// C++ style multidimension arrays

// static multidimension array
// int arr[2][2] = {{15, 68}, {2, 7}};

// C#  multidimension array
//int[,] mdArray = new int[2, 2] { { 15, 68 }, { 2, 7 } };
//Console.WriteLine(mdArray.Rank);
//Console.WriteLine(mdArray[0,0]);
//for (int i = 0; i < 2; i++)
//{
//	for (int j = 0; j < 2; j++)
//	{
//		Console.Write($"{mdArray[i, j]}\t");
//	}
//    Console.WriteLine();
//}
Random random = new Random();
// Jagged array
//int[][] jArr = new int[3][];
//jArr[0] = new int[10];
//jArr[1] = new int[3];
//jArr[2] = new int[5];

//for (int i = 0; i < jArr.Length; i++)
//{
//	for (int j = 0; j < jArr[i].Length; j++)
//	{
//		jArr[i][j] = random.Next(10, 99);
//	}
//}

//for (int i = 0; i < jArr.Length; i++)
//{
//    for (int j = 0; j < jArr[i].Length; j++)
//    {
//        Console.Write($"{jArr[i][j]} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine(jArr[0][3]);


int[] arr2 = [15, 68, 12, 7, 89];
int i = 0;
while (i < arr2.Length)
{
    Console.Write($"{arr2[i]} ");
    i++;
}
Console.WriteLine();

for (int j = 0; j < arr2.Length; j++)
{
    Console.Write($"{arr2[j]} ");
}
Console.WriteLine();

foreach (var item in arr2)
{
    Console.Write($"{item} ");
    // item = 45; error - foreach-de istifade edilen deyisheni
    // modifikasiya etmek mumkun deyil
}
Console.WriteLine();
