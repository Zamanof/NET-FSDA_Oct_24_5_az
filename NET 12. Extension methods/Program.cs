// Extension methods

string word = "Lorem      Ipsum dolo     r      sit amet.       Salam. Hi";
//Console.WriteLine(CountWords(word));


Console.WriteLine(word.CountWords());
Console.WriteLine(word.CountSpaces());
Console.WriteLine(word.CountVowels());
Console.WriteLine("123".ToInt() + 12);


//int CountWords(string word)
//{
//    var words = word.Split(' ');
//    return words.Length;
//}
