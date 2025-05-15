// Structs

// 1. Struct obyektleri stack-de yaranir

// 2. Prametrli constructor yaratdiqda,
//    default constructor silinmir

// 3.Struct-larda copy hemishe deep copy-dir
//   (yeni value-ler copy olunur)

// 4. Sturct-lardan toremek mumkun deyil
   

Point point = new Point();
//point.x = 78;
//point.y = 98;
Console.WriteLine($"x = {point.x}, y = {point.y}");
Point point1 = point;
Console.WriteLine($"x = {point1.x}, y = {point1.y}");
//point.y = 8;
//Console.WriteLine($"x = {point.x}, y = {point.y}");
//Console.WriteLine($"x = {point1.x}, y = {point1.y}");

Console.WriteLine(point.arr[0]); 
Console.WriteLine(point1.arr[0]);
point.arr[0] = 1100;
Console.WriteLine(point.arr[0]);
Console.WriteLine(point1.arr[0]);

Console.WriteLine(point.GetType());


