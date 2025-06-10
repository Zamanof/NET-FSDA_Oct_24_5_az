// Annonymous methods
using System.Threading.Channels;

List<int> numbers = new();
FillList(numbers);
ShowList(numbers);

#region method and delegate
//Func<int, bool> predicate = IsEven;

//var evens = numbers.Where(predicate).ToList();
//var evens = numbers.Where(IsEven).ToList();

//ShowList(evens);
//bool IsEven(int number)
//{
//	return number % 2 != 0;
//}
#endregion

#region Annonymous methods
// anonim metodlar
// delegate(parameter_list){some_code_block; return value}

/*
 delegate (int x) { return x % 2 != 0; }
			equals
bool IsEven(int number)
{
	return number % 2 != 0;
}
*/

//var evenNumbers = numbers.Where(delegate (int x) { return x % 2 != 0; })
//						 .ToList();
//ShowList(evenNumbers);
#endregion

#region Lambda expression
// (parameters_list) => {some_code_block; return value;}
/*
 
(x) => x % 2 != 0 - Lambda expression
		equals
delegate (int x) { return x % 2 != 0; } - anonim metod
		equals
bool IsEven(int number)	- normal metod
{
	return number % 2 != 0;
}

lambda => anonim metod => delegate
*/
//var evenInts = numbers.Where((x) => x % 2 != 0).ToList();
//var neagtiveInts = numbers.Where((x) => x < 0).ToList();
//ShowList(evenInts);
//ShowList(neagtiveInts);

//var func = (int x) => x * x;
//Console.WriteLine(func(5)); 
#endregion

// Lambda ifadeleri bu shekilde istifade meslehet deyil
//var fill = (List<int> lst) =>
//{
//	Random random = new();
//	for (int i = 0; i < 10; i++)
//	{
//		lst.Add(random.Next(-99, 99));
//	}
//};
//List<int> ints = new();
//fill(ints);
//ints.ForEach(Console.WriteLine);

/*
Lambda expressions:

C++:		[](int x){return x<0;}

Python:		lambda x: x < 0;

C#:			x => x < 0;
 
*/

void FillList(List<int> lst)
{
    Random random = new();
	for (int i = 0; i < 10; i++)
	{
		lst.Add(random.Next(-99, 99));
	}
}

void ShowList(List<int> lst)
{

	foreach (var item in lst)
	{
        Console.Write($"{item} ");
	}
    Console.WriteLine();
}

