// StreamWriter, StreamReader
using System.Text;

#region writer
//string txt = "Lorem ipsum dolor";

//FileStream file = new("myFile.txt", FileMode.Create);
//StreamWriter writer = new StreamWriter(file, Encoding.Unicode );
//foreach (var symbol in txt)
//{
//    writer.Write($"{symbol} ");
//}
//writer.Close();
//file.Close();
#endregion

#region writer with using
//string txt = "Lorem ipsum dolor sit amet";
//using FileStream file = new("myFile.txt", FileMode.Create);
//using StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
//foreach (var symbol in txt)
//{
//    writer.Write($"{symbol} ");
//}
#endregion


#region reader
//FileStream file = new("myFile.txt", FileMode.Open);
//StreamReader reader = new StreamReader(file, Encoding.Unicode);
//string line = reader.ReadToEnd();
//Console.WriteLine(line);
//reader.Close();
//file.Close();
#endregion

#region reader with try finally
//FileStream file = null;
//StreamReader reader = null;

//try
//{
//    file = new("myFile.txt", FileMode.Open);
//    reader = new StreamReader(file, Encoding.Unicode);
//    string line = reader.ReadToEnd();
//    Console.WriteLine(line);
//}
//finally
//{
//    reader.Close();
//    file.Close();
//}
#endregion

#region reader with using
//using(FileStream file = new FileStream("myFile.txt", FileMode.Open))
//{
//    using(StreamReader reader = new StreamReader(file, Encoding.Unicode))
//    {
//        string line = reader.ReadToEnd();
//        Console.WriteLine(line);
//    }
//}



#endregion