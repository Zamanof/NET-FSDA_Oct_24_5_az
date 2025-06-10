// Extension methods

//Console.WriteLine(CountWords(word));



static class StringExtensions
{
    public static int CountWords(this string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        return str.Split().Length;
    }

    public static int CountSpaces(this string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        return str.Count(s => s == ' ');
    }

    public static int CountVowels(this string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        return str.ToLower().Count(s => s == 'a'|| s == 'o' ||s == 'u' || s == 'e' || s == 'i');
    }

    public static int ToInt(this string str)
    {
        return int.Parse(str); 
    }

}


//int CountWords(string word)
//{
//    var words = word.Split(' ');
//    return words.Length;
//}
