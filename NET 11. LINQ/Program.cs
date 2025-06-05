// LINQ - Language Integrated Query
// Kolleksiyalarla(choxluqlarla) ishlemek uchun sorqu dilidir
/*
LINQ to Objects 
LINQ to Dataset 
LINQ to SQL 
LINQ to XML
LINQ to Entities
PLINQ - Paralell LINQ 
*/

List<int> arr = [98, -8, 665, -70, 41, 987, -987, -12, -369, 36, 125, 225, -12, 10];
ShowArray(arr);
#region from, select
// from - datanin menbeyi
// select sechim

IEnumerable<int> query = from i in arr
                         select i;
//ShowArray(query);

//arr[0] = 3;
//arr.Add(36);
//ShowArray(arr);
//ShowArray(query);
#endregion

#region where
// where - sechim uchun shert
//List<int> ints=[];
//foreach (var item in arr)
//{
//    if (item % 2 == 0 && item > 0) ints.Add(item);
//}
//ShowArray(ints);

//query = from i in arr
//        where i % 2 == 0 && i > 0
//        select i;
//ShowArray(query);
#endregion

#region orderby ascending(by default) / descending
//query = from i in arr
//        where i > 0
//        orderby i ascending
//        select i;

//ShowArray(query);

//query = from i in arr
//        where i > 0
//        orderby i descending
//        select i;
//ShowArray(query);
#endregion

#region group by

//IEnumerable<IGrouping<int, int>> group = from i in arr
//                                         where i > 0
//                                         group i by i % 2; // 0 1

//foreach (var item in group)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }
//}



#endregion

#region into

//var query_into = from i in arr
//                 where i > 0
//                 group i by i % 2 into result
//                 from j in result
//                 group j by j % 10;

//foreach (var item in query_into)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }
//}
#endregion



void ShowArray(IEnumerable<int> arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}