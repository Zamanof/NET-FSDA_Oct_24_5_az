// string

#region string initialize and compare
//string str1 = "Hello";
//string str2 = new string("Hello");
//Console.WriteLine(str1 == str2);
//Console.WriteLine(str1.Equals(str2));
//Console.WriteLine(str1.CompareTo(str2));

#endregion

#region string constructors with char parameters 
//char[] chars = new char[] { 'S', 'a', 'l', 'a', 'm' };
//Console.WriteLine(chars);
//string str3 = new string(chars);
//Console.WriteLine(str3);
//string str4 = new string('_', 25);
//Console.WriteLine(str4);
#endregion

#region intern pool
// intern pool
//string name1 = "Nadir";
//string name2 = "Nadir";
//string myName = name1;
//string name3 = new string("Nadir");
//string na = "Na";
//string dir = "dir";
//string name4 = na + dir;

//Console.WriteLine($@"name1  = {name1}
//name2  = {name2}
//name3  = {name3}
//myName = {myName}");
////Console.WriteLine(name1[0]);

//name1 += 'a';
//Console.WriteLine($@"name1  = {name1}
//name2  = {name2}
//name3  = {name3}
//myName = {myName}");

//Console.WriteLine($"ReferenceEquals name1==name2 -> {object.ReferenceEquals(name1, name2)}");
//Console.WriteLine($"ReferenceEquals name1==name3 -> {object.ReferenceEquals(name1, name3)}");
//Console.WriteLine($"ReferenceEquals name1==name4 -> {object.ReferenceEquals(name1, name4)}");
//Console.WriteLine($"ReferenceEquals name1==myName -> {object.ReferenceEquals(name1, myName)}");
#endregion

#region string range, indices
//string word = "lorem ipsum dolor";
//Console.WriteLine(word[0]);
//Console.WriteLine(word[0..5]);
//Console.WriteLine(word[^1]);

//string new_word = word[0].ToString().ToUpper();
//for (int i = 1; i < word.Length; i++)
//{
//    new_word += word[i];
//}
//Console.WriteLine(new_word);

//string new_word = word[0].ToString().ToUpper() + word[1..];
//Console.WriteLine(new_word);
#endregion

string word = "Lorem,   ipsum ,,   dolor, sit, amet";
//Console.WriteLine(word.Length);
//Console.WriteLine(word.ToUpper());
//Console.WriteLine(word.ToLower());

//var strings = word.Split(',');
//foreach (var item in strings)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//var strings2 = word.Split(',', StringSplitOptions.RemoveEmptyEntries);
//foreach (var item in strings2)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//var strings3 = word.Split(',', StringSplitOptions.TrimEntries);
//foreach (var item in strings3)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();

//Console.WriteLine(word.IndexOf('a'));

// Raw string literals - introducing C# 11
//string code = $$"""
//    string word = "Lorem,   ipsum ,,   dolor, sit, amet";
//    Console.WriteLine({{word.Length}});
//    Console.WriteLine(word.ToUpper());
//    Console.WriteLine(word.ToLower());

//    var strings = word.Split(',');
//    foreach (var item in strings)
//    {
//        Console.WriteLine(item);
//    }
//    Console.WriteLine();
//    var strings2 = word.Split(',', StringSplitOptions.RemoveEmptyEntries);
//    foreach (var item in strings2)
//    {
//        Console.WriteLine(item);
//    }
//    Console.WriteLine();
//    var strings3 = word.Split(',', StringSplitOptions.TrimEntries);
//    foreach (var item in strings3)
//    {
//        Console.WriteLine(item);
//    }
//    Console.WriteLine();

//    Console.WriteLine(word.IndexOf('a'));
//    """;
//Console.WriteLine(code);

