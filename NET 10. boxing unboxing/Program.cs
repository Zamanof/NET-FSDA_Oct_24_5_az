// boxing - unboxing

// Boxing
// value type deyeri,
// reference type (object) deyishene yazmaqdir

object obj = 29.5;
Console.WriteLine($"Boxing - {obj}");

// Unboxing
double number = (double)obj;
Console.WriteLine($"Unboxing - {obj}");



Console.WriteLine((int)obj + 36);