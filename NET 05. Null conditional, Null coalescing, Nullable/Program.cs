#region ?. null conditional operator
// Butun reference type-larin(class-larin)
// default deyeri null-dur
//string name = "SALAM";
//if (name != null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}

//if (name is not null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
//name = name?.ToLower();
//Console.WriteLine(name);
#endregion

#region ?? null coalescing operator
//string name = "Hello";

//if (name is null)
//{
//    name = "Empty";
//}
//Console.WriteLine(name);

//string name1 = name is null ? "Empty" : name;
//Console.WriteLine(name1);

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
//string name2 = name ?? "Empty";
//Console.WriteLine(name2);
#endregion

#region Nullable type
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
//int? number = null;
//number = 15;

//Nullable<int> numb = null;
//Console.WriteLine(number+25);
#endregion

#region ! - null forgiving operator
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
string name = null!;
Console.WriteLine(name);
#endregion
