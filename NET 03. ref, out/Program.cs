/*
    ref parameter
    out parameter
    in parameter
 
 */

using System.Text;

int number = 18;
int number1 = 156;
int[] arr = [5, 69, 4, 223, 64, 1, 33];
StringBuilder arrToString = new();
foreach (var item in arr)
{
    arrToString.Append($"{item} ");
}

Console.WriteLine($@"Before call ChangeValue method: 
number  = {number}
number1 = {number1}
arr     = {arrToString.ToString()}");

ChangeValue(number, arr);

arrToString.Clear();
foreach (var item in arr)
{
    arrToString.Append($"{item} ");
}

Console.WriteLine();

Console.WriteLine($@"After call ChangeValue method: 
number  = {number}
number1 = {number1}
arr     = {arrToString.ToString()}");

void ChangeValue(int number, int[] arr)
{
    number += 23;
    arr[0] = number;
}


