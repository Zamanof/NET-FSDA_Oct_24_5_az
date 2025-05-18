using System.Text;
/*
    ref - metodlarin ichine Value type deyishenleri reference olaraq gondermek uchundur.
            Method-a gonderilmezden qabaq mutleq initialize olunmalidir(Deyer verilmelidir)
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref

    out - metodlarin ichine Value type deyishenleri reference olaraq gondermek uchundur.
            Method-a gonderilmezden qabaq initialize olunmasi vacib deyil.
            Method-un ichinde mutleq initialize olunmalidir.
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out

    in - metodlarin ichine Value type deyishenleri reference olaraq gondermek uchundur.
            Amma deyishen methodun ichinde yalniz oxumaq mumkun olacaq(readonly)
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/in
 
 */


//int number = 18;
//int number1 = 156;
//int[] arr = [5, 69, 4, 223, 64, 1, 33];
//StringBuilder arrToString = new();
//foreach (var item in arr)
//{
//    arrToString.Append($"{item} ");
//}

//Console.WriteLine($@"Before call ChangeValue method: 
//number  = {number}
//number1 = {number1}
//arr     = {arrToString.ToString()}");

//ChangeValue(number, arr, ref number, out number1);

//arrToString.Clear();
//foreach (var item in arr)
//{
//    arrToString.Append($"{item} ");
//}

//Console.WriteLine();

//Console.WriteLine($@"After call ChangeValue method: 
//number  = {number}
//number1 = {number1}
//arr     = {arrToString.ToString()}");


int numb;
MyIntTryParse(Console.ReadLine()!, out numb);
MyIntTryParse(Console.ReadLine()!, out int numb2);

Console.WriteLine($"numb = {numb}, numb2 = {numb2}");

void ChangeValue(int number, int[] arr, ref int numb1, out int numb2)
{
    number += 23;
    arr[0] = number;
    numb1++;
    numb2 = 25;
}

bool MyIntTryParse(string value, out int outValue)
{
    try
    {
        outValue = int.Parse(value);
        return true;
    }
    catch
    {

        outValue = default;
        return false;
    }
}


