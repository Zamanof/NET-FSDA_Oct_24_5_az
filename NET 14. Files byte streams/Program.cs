// FileStream, MemoryStream, BufferedStream -> Stream
/*
Absolute path:
- C:\Users\MoguDa\source\repos\Zamanof\NET-FSDA_Oct_24_5_az\NET 14. Files byte streams\file.txt
- C:\Users\MoguDa\source\repos\Zamanof\NET-FSDA_Oct_24_5_az\NET 14. Files byte streams\Files\file.txt
- C:\Users\MoguDa\source\repos\Zamanof\NET-FSDA_Oct_24_5_az\file.txt
- C:\Users\MoguDa\source\repos\Zamanof\NET-FSDA_Oct_24_5_az\Datas\file.txt

Relative path:
- file.txt
- Files\file.txt
- ..\file.txt
- ..\Datas\file.txt
*/

using System.Text;

string filePath = "file.txt";
//Console.WriteLine("Metn daxil edin: ");
//string text = Console.ReadLine();
//SaveToFile(filePath, text);

Console.WriteLine(LoadFromFile(filePath));

void SaveToFile(string path, string text)
{
    FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
    byte[] bytes = Encoding.Default.GetBytes(text);
    fileStream.Write(bytes,0, bytes.Length);
    fileStream.Close();
}

string LoadFromFile(string path)
{
    FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
    byte[] bytes = new byte[(int)fileStream.Length];
    fileStream.Read(bytes, 0, bytes.Length);
    fileStream.Close();
    return Encoding.Default.GetString(bytes);
}
