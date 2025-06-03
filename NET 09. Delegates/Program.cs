// delgates
// delegate return_datatype delegate_name([parameter list])


#region delagate
//double numb1 = default;
//double numb2 = default;

//Console.WriteLine("Birinci ededi daxil edin");
//double.TryParse(Console.ReadLine(), out numb1);
//Console.WriteLine("Ikinci ededi daxil edin");
//double.TryParse(Console.ReadLine(), out numb2);

//char operation = default;
//Console.WriteLine("Emeliyatlardan birini sechin: +, -, *, /");
//char.TryParse(Console.ReadLine(), out operation);

//CalculatorDelagate calculator = null!;

//switch ((arithmeticOperators)operation)
//{
//    case arithmeticOperators.ADD:
//        calculator = add;
//        break;
//    case arithmeticOperators.SUBTRACT:
//        calculator = subtract;
//        break;
//    case arithmeticOperators.MULTIPLE:
//        calculator = multiple;
//        break;
//    case arithmeticOperators.DIVIDE:
//        calculator = divide;
//        break;
//}

////if (calculator is not null) 
////    Console.WriteLine(calculator(numb1, numb2));

//if (calculator is not null)
//    Console.WriteLine(calculator.Invoke(numb1, numb2));


#endregion

#region Multicast delegate
//CalculatorDelagate operations = add;
//operations += subtract;
//operations += multiple;
//operations += divide;

//double number1 = 97, number2 = 3;

//Console.WriteLine(operations(number1, number2));

//foreach (CalculatorDelagate item in operations.GetInvocationList())
//{
//    Console.WriteLine(item(number1, number2));
//}

//var delegateList = operations.GetInvocationList();
//Console.WriteLine(delegateList[0].Method);
//Console.WriteLine(delegateList[1].Method);
//Console.WriteLine(delegateList[2].Method);
//Console.WriteLine(delegateList[3].Method);

//Console.WriteLine(delegateList[0].DynamicInvoke(number1, number2));
//Console.WriteLine(delegateList[1].DynamicInvoke(number1, number2));
//Console.WriteLine(delegateList[2].DynamicInvoke(number1, number2));
//Console.WriteLine(delegateList[3].DynamicInvoke(number1, number2));

#endregion

#region Generic delegates
//GenericCalculator<double> genericCalculator = add;
//GenericCalculator<int> genericCalculator1 = Foo;
//Console.WriteLine(genericCalculator(25, 36));
#endregion

#region Sdandard generic delegates
// Action<T>, Func<T>, Predicate<T>, Comparison<T>

using System;
using System.Threading.Channels;

List<int> ints = [36, 98, 4, 223, -78, -6, 23, -4];

//var lst = Filter(ints, isOdd);
//foreach (var item in lst)
//{
//    Console.Write($"{ item} ");
//}
//Console.WriteLine();

//var lst1 = Filter(ints, delegate(int x) { return x > 0; });
//foreach (var item in lst1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

#region  Action<T>
//// Action<T> - 16-ya qeder parametr qebul eden ve void qaytaran metodlari saxlaya bilen delegate-dir

//int[] arr = new int[17];
//Random random = new();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(-99, 99);
//}

//foreach (var item in arr)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//// Action<int> <=> public delegate void del_name(int x)

//FilteringShow(arr, ShowNegative);
#endregion

#region Func<T>
// Func<T> 16-ya qeder parameter qebul ede bilen ve return type-i olan generic delegate-dir
// Func<double, double, double> func <=> public delegate double delegate_name(double left, double right);

Console.WriteLine(Calculator(5, 78, divide));
#endregion

#region Comparison<T>
// Comparison <T> - eyni tipli 2 parametr qebul edib int tipli deyer qaytaran generic delegate

//List<Human> humans = [
//    new Human(){Name="Nadir", Age =45},
//    new Human(){Name="Qadir", Age =43},
//    new Human(){Name="Briqadir", Age =390},
//    new Human(){Name="Mezahir", Age =145},
//    new Human(){Name="Shair", Age =850}
//    ];
//foreach (var item in humans)
//{
//    Console.WriteLine(item);
//}
////humans.Sort(NameComparison);
////humans.Sort(AgeComparison);
//Console.WriteLine();
//foreach (var item in humans)
//{
//    Console.WriteLine(item);
//}

//int NameComparison(Human human1, Human human2)
//{
//    return human1.Name.CompareTo(human2.Name);
//}

//int AgeComparison(Human human1, Human human2)
//{
//    return human1.Age.CompareTo(human2.Age);
//}

#endregion

#region Predicate<T>
// Predicate<T> - bir parameter qebul edib bool tipli deyer qaytaran generic delegate
// Predicate<int> <=> public delegate bool delegate_name(int x)
// 
//var negativList = FilterWithPredicate(ints, isNegative);

//negativList.ForEach(Console.WriteLine);
#endregion

double Calculator(double numb1, double numb2, Func<double, double, double> func)
{
    return func(numb1, numb2);
}


#endregion

List<int> Filter(List<int> ints, FilterDeleagte filterDeleagte)
{
    List<int> tmp = [];
    foreach (var item in ints)
    {
        if (filterDeleagte(item)) tmp.Add(item);
    }
    return tmp;
}

List<int> FilterWithPredicate(List<int> ints, Predicate<int> predicate)
{
    List<int> tmp = [];
    foreach (var item in ints)
    {
        if (predicate(item)) tmp.Add(item);
    }
    return tmp;
}
void FilteringShow(int[] arr, Action<int> action)
{
    foreach (var item in arr)
    {
        action(item);
    }
}

bool isNegative(int x) => x < 0;
bool isOdd(int x) => x % 2 == 0;
void ShowNegative(int x)
{
    if (isNegative(x)) Console.WriteLine(x);
}
;

double calcResult(double left, double right, CalculatorDelagate delagate)
{
    return delagate(left, right);
}

int Foo(int left, int right)
{
    return left - 1 * right;
}
double add(double left, double right)
{
    return left + right;
}
double subtract(double left, double right)
{
    return left - right;
}
double multiple(double left, double right)
{
    return left * right;
}
double divide(double left, double right)
{
    if (right != 0)
        return left / right;
    throw new DivideByZeroException();
}

public delegate double CalculatorDelagate(double left, double right);
public delegate bool Predic(int x);

// Generic(template) delegates
public delegate T GenericCalculator<T>(T left, T right);
public delegate bool FilterDeleagte(int a);

enum arithmeticOperators { ADD = '+', SUBTRACT = '-', MULTIPLE = '*', DIVIDE = '/' };