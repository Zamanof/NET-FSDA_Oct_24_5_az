using System.Text;

// string vs StringBuilder

//string word = "Hi";

//for (int i = 0; i < 100; i++)
//{
//    word += 'a';
//}
//Console.WriteLine(word);


//StringBuilder sb = new StringBuilder("Hi");
//Console.WriteLine(sb.Capacity);
//Console.WriteLine(sb.Length);
//Console.WriteLine();
//for (int i = 0; i < 100; i++)
//{
//    sb.Append('a');
//    Console.WriteLine(sb.Capacity);

//}
//var str = sb.ToString();
//Console.WriteLine(str);

StringBuilder numbers = new StringBuilder();
int count = 0;
for (int i = 0; i < 10000; i++)
{
    numbers.Append($"{i}, ");
    if (count != numbers.Capacity) Console.WriteLine(numbers.Capacity);
    count = numbers.Capacity;
}
