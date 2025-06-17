// regular expressions
using System.Text.RegularExpressions;

string pass = "P@ss123456";
string mail = "salam@google.com";


#region Classic Way

//List<bool> criteries = [false, false, false];

// v1
//for (int i = 0; i < pass.Length; i++)
//{
//    if (pass[i] >= 'A' && pass[i] <= 'Z') criteries[0] = true;
//    if (pass[i] >= 'a' && pass[i] <= 'z') criteries[1] = true;
//    if (pass[i] >= '0' && pass[i] <= '9') criteries[2] = true;
//}
//if(criteries.All(x=> x == true)) Console.WriteLine("Password is correct");
//else Console.WriteLine("Incorrect Password");

// v2
//if (pass.Any(x => x >= 'A' && x <= 'Z')) criteries[0] = true;
//if (pass.Any(x => x >= 'a' && x <= 'z')) criteries[1] = true;
//if (pass.Any(x => x >= '0' && x <= '9')) criteries[2] = true;

//if (criteries.All(x => x == true)) Console.WriteLine("Password is correct");
//else Console.WriteLine("Incorrect Password");

#endregion


#region RegEx
// RegEx - Regular Exppression:
/*
 .          - istenilen bir simvol
\w          - istenilen bir herf-reqem simvol
\W          - istenilen bir herf-reqem olmayan simvol
\s          - istenilen boshluq simvol
\S          - istenilen boshluq olmayan simvol
\d          - istenilen onluq reqem simvol
\D          - istenilen onluq reqem olmayan simvol
[symbols]   - moterize ichinde gosterilen simvollardan her hansi biri
[^symbols]  - moterize ichinde gosterilen simvollardan hech biri
[a-r]       - moterize ichinde gosterilen araliqda simvollardan biri
[^a-r]      - moterize ichinde gosterilen araliqda simvollardan hech biri

*           - shablon 0 ve ya daha chox defe tekrarlanir
+           - shablon 1 ve ya daha chox defe tekrarlanir         
?           - shablon 0 ve ya 1 defe tekrarlanir
{n, m}      - shablon n defeden az olmayaraq ve m defeden chox olmayaraq tekrarlanir
{n,}       - shablon n defeden az olmayaraq  tekrarlanir
{n}         - shablon n defe tekrarlanir
^           - shablon metnin evvelinde olmalidr
$           - shablon metnin sonunda olmalidr
*/
#endregion

//string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
//Regex regex = new(passwordPattern);
//Console.WriteLine(regex.IsMatch(pass));

Regex mailPattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
Console.WriteLine(mailPattern.IsMatch(mail));