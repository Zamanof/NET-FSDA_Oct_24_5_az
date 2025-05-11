/*
 C# -da butun tipler object tipinden toreyib

value type:
    - struct - dir
    - stack-de yaranir - FILO
    - compare: by value
    - copy: value 
    - new keyword-u olmadan da yaradilir
    - clear: scope bitdikde avtomatik olaraq yaddashdan silinir

reference type:
    - class - dir
    - Heap-de yaranir
    - compare: by reference
    - copy: reference
    - new keyword-u ile yaradilir
    - clear - Garbage Collector temizleyir 
*/

// value types
bool check = false;                 // System.Boolean - 1 byte
char symb = 'a';                    // System.Char - 2 byte
byte byt = 255;                     // System.Byte - 1 byte (0-255) 
sbyte sbyt = 125;                   // System.SByte - 1 byte (-128 - 127) 
short numb = 365;                   // System.Int16 - 2 byte
ushort unumb = 365;                 // System.UInt16 - 2 byte
int number = 65;                    // System.Int32 - 4 byte
uint uNumber = 489;                 // System.UInt32 - 4 byte
long longNumb = 458;                // System.Int64 - 8 byte
ulong uLongNumb = 69;               // System.UInt64 - 8 byte
    
float numb1 = 26.36f;               // System.Single - 4 byte
double numb2 = 26.36;               // System.Double - 8 byte

decimal dcm = 65.7m;                // System.Decimal - 16 byte

// reference type
string name = "Nadir";              // System.String
string name1 = new string("Nadir"); // System.String



