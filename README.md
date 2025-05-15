<details>
<summary>Dərs 1</summary>



<details>
<summary>.NET Arxitekturası və Komponentləri</summary>


**.NET** — Microsoft tərəfindən yaradılmış, fərqli dillərdə və platformalarda proqramlaşdırma üçün vahid ekosistemdir.

> `.NET Framework` yalnız Windows üçündür  
> `.NET Core / .NET 5+` açıq mənbəli, modul əsaslı və çoxplatformalı müasirləşdirilmiş versiyadır

---

</details>

<details>
<summary>1. CLR – Common Language Runtime</summary>


`.NET` proqramlarının əsas işləmə mühərrikidir.

**Əsas funksiyaları:**
- IL (Intermediate Language) → maşın koduna çevrilmə (JIT)
- Yaddaş idarəsi (`Garbage Collector`)
- Təhlükəsizlik və istisna (exception) idarəsi
- Tip yoxlaması və çoxaxınlılıq (threads)

> `.NET Core` üçün bu komponent `CoreCLR` adlanır.

---

</details>

<details>
<summary>2. FCL – Framework Class Library</summary>


`.NET` üçün **standart siniflər toplusudur**:

- `System.IO` – fayllarla işləmə  
- `System.Net` – şəbəkə  
- `System.Linq` – verilənlər üzərində sorğular  
- `System.Threading` – paralel proqramlaşdırma  
- `System.Text.Json` – JSON işləmə

> `.NET Core`-da bu kitabxana `CoreFX` adlanır.

---

</details>

<details>
<summary>3. BCL – Base Class Library</summary>


`FCL`-in əsas hissəsidir, bazadakı sinifləri əhatə edir:

```csharp
string name = "Nadir";
List<int> nums = new List<int> { 1, 2, 3 };
DateTime now = DateTime.Now;
```

---

</details>

<details>
<summary>4. CTS – Common Type System</summary>


Bütün .NET dilləri üçün **ümumi tip sistemi** yaradır.

| C#       | VB.NET   | CTS Tipi        |
|----------|----------|-----------------|
| `int`    | `Integer`| `System.Int32`  |
| `string` | `String` | `System.String` |
| `bool`   | `Boolean`| `System.Boolean`|

---

</details>

<details>
<summary>5. CLS – Common Language Specification</summary>


Müxtəlif dillərin bir-biri ilə uyğun işləməsi üçün **qaydalar toplusudur**.  
CLS uyğun siniflər bütün .NET dillərində istifadə oluna bilər.

---

</details>

<details>
<summary>6. MSIL / CIL – Aralıq Kod</summary>


`.NET` kodu əvvəlcə **MSIL** (Microsoft Intermediate Language) və ya **CIL**-ə çevrilir.  
Sonra bu kod JIT vasitəsilə maşın koduna çevrilir və icra olunur.

---

</details>

<details>
<summary>7. JIT – Just-In-Time Compiler</summary>


**JIT kompilyatoru**, MSIL → maşın kodu çevirir, proqram icra olunanda.

> `.NET Core`-da **RyuJIT** adlı sürətli və optimallaşdırılmış versiyası istifadə olunur.

---

</details>

<details>
<summary>8. Garbage Collector (GC)</summary>


Yaddaşda istifadə olunmayan obyektləri **avtomatik təmizləyir**:

- Yaddaş sızmalarının qarşısı alınır  
- Əllə `delete` yazmağa ehtiyac yoxdur

---

</details>

<details>
<summary>9. Metadata və Reflection</summary>


`.dll` və `.exe` fayllarında **sinif və metodlar haqqında məlumat** saxlanır.

```csharp
Type t = typeof(MyClass);
MethodInfo[] methods = t.GetMethods();
```

---

</details>

<details>
<summary>10. NuGet – Paket İdarəetməsi</summary>


`.NET` üçün rəsmi **paket meneceri**:

```bash
dotnet add package Newtonsoft.Json
```

- On minlərlə açıq mənbə paketi
- Öz paketlərini yaratmaq mümkündür

---

</details>

<details>
<summary>11. .NET CLI – Komanda Sətiri Vasitəsi</summary>


```bash
dotnet new console -n HelloApp
dotnet run
```

Layihə yaratmaq, test, qurmaq və yayımlamaq üçün istifadə olunur.

---

</details>

<details>
<summary>12. SDK – Software Development Kit</summary>


`.NET SDK` tərkibinə daxildir:

- Kompilyatorlar (`Roslyn`)  
- `dotnet` CLI  
- Kitabxanalar (BCL, FCL)  
- Şablonlar və əlavə vasitələr

---

</details>

<details>
<summary>13. ASP.NET Core</summary>


Krosplatformalı və yüksək performanslı **veb çərçivə**:

- REST API-lər, Web Apps, SignalR  
- Minimal API, Blazor, Razor Pages

---

</details>

<details>
<summary>14. Entity Framework Core (EF Core)</summary>


Verilənlər bazası ilə işləmək üçün **ORM vasitəsidir**.

```csharp
var users = db.Users.Where(u => u.IsActive).ToList();
```

- SQL Server, PostgreSQL, SQLite dəstəyi  
- Migration, LINQ, AsNoTracking

---

</details>

<details>
<summary>15. RyuJIT</summary>


`.NET Core` üçün **yeni nəsil JIT kompilyatorudur**:

- SIMD və ARM dəstəyi  
- Yüksək performans  
- Ağıllı optimallaşdırma

---

</details>

<details>
<summary>Müqayisə Cədvəli</summary>


| Xüsusiyyət     | .NET Framework  | .NET Core / .NET 5+      |
|----------------|------------------|---------------------------|
| Platforma       | Yalnız Windows   | Windows, Linux, macOS     |
| Açıq mənbə      | Xeyr             | Bəli                      |
| Modulyarlıq     | Az               | Yüksək                    |
| Performans      | Orta             | Yüksək                    |
| Aktiv inkişaf   | Zəif             | Aktiv                     |

</details>

<details>
<summary>C# Top-Level Statements və Data Type-lar</summary>


---

</details>

<details>
<summary>🔹 Top-Level Statements nədir?</summary>


C# 9.0-dan başlayaraq `Main` metodu olmadan birbaşa kod yazmaq mümkündür.

Ən sadə nümunə:

```csharp
Console.WriteLine("Salam, dünya!");
```

Əvvəlki versiyalarda eyni kod belə olardı:

```csharp
class Program
{
    static void Main()
    {
        Console.WriteLine("Salam, dünya!");
    }
}
```

Bu xüsusiyyət tədris və skript əsaslı tətbiqlər üçün idealdır.

---

</details>

<details>
<summary>🔸 C# Tip Sistemi</summary>


C#-da bütün tiplər `object`-dən törəyir.

```csharp
int number = 5;
object obj = number; // boxing
```

---

</details>

<details>
<summary>🟦 Value Types (Qiymət Tipləri)</summary>


| Tip         | System Tipi        | Ölçü (byte) | Aralık (təqribi)              |
|-------------|--------------------|-------------|-------------------------------|
| `bool`      | System.Boolean     | 1           | true / false                  |
| `char`      | System.Char        | 2           | Unicode (0–65535)             |
| `byte`      | System.Byte        | 1           | 0 – 255                       |
| `sbyte`     | System.SByte       | 1           | -128 – 127                    |
| `short`     | System.Int16       | 2           | -32,768 – 32,767              |
| `ushort`    | System.UInt16      | 2           | 0 – 65,535                    |
| `int`       | System.Int32       | 4           | -2,147,483,648 – 2,147,483,647|
| `uint`      | System.UInt32      | 4           | 0 – 4,294,967,295             |
| `long`      | System.Int64       | 8           | ±9 x 10^18                    |
| `ulong`     | System.UInt64      | 8           | 0 – 18,446,744,073,709,551,615|
| `float`     | System.Single      | 4           | ±1.5 x 10^−45 – ±3.4 x 10^38  |
| `double`    | System.Double      | 8           | ±5.0 x 10^−324 – ±1.7 x 10^308|
| `decimal`   | System.Decimal     | 16          | ±1.0 x 10^−28 – ±7.9 x 10^28  |

🧠 Value type-lar `struct` olaraq təyin olunur və **stack** yaddaşda saxlanır.

---

</details>

<details>
<summary>🟪 Reference Types (İstinad Tipləri)</summary>


| Tip         | System Tipi        | Xüsusiyyətlər                      |
|-------------|--------------------|------------------------------------|
| `string`    | System.String      | Unicode simvol sırası, immutable  |
| `object`    | System.Object      | Bütün tiplərin kökü               |
| `dynamic`   | System.Object      | Runtime tip yoxlanışı              |
| `class`, `interface`, `array` və s. | - | Heap-də saxlanır və GC tərəfindən idarə olunur |

📌 Reference type-lar `new` açarı ilə yaradılır və **heap** yaddaşda yerləşir.

---

</details>

<details>
<summary>✅ Value vs Reference Types</summary>


| Xüsusiyyət     | Value Type                   | Reference Type               |
|----------------|------------------------------|------------------------------|
| Yaradılma      | `struct`                     | `class`                      |
| Yaddaş         | Stack                        | Heap                         |
| Nümunə         | `int`, `bool`, `double`      | `string`, `object`, `array`  |
| Copy davranışı | Dəyər kopyalanır             | İstinad (referans) kopyalanır|
| Silinmə        | Scope bitdikdə silinir       | Garbage Collector tərəfindən |

---

</details>

<details>
<summary>💡 Nümunələr</summary>


```csharp
// Value types
int age = 30;
float pi = 3.14f;
bool isActive = true;

// Reference types
string name = "Nadir";
object anything = 123;
int[] numbers = { 1, 2, 3 };
```

---

</details>

<details>
<summary>📌 Nəticə</summary>


C# tip sistemi güclü və təhlükəsizdir. Bütün tiplər `object`-dən törəyir və onlar stack və heap-də fərqli şəkildə idarə olunur. `Top-Level Statements` isə proqram yazmağı daha da sadələşdirir.

---

</details>

<details>
<summary>C# Tip Sistemində `object` və Tip Növlərinin Müqayisəsi</summary>


C# dilində **bütün tiplər** `object` tipindən törəyir. Bu, .NET-in **Common Type System (CTS)** modelinə əsaslanır.

Aşağıda **Value Type** və **Reference Type** tiplərinin fərqləri izah olunub.

---

</details>

<details>
<summary>🔹 Ümumi Qeyd</summary>


> ✔️ C#-da istər `int`, `float`, `bool`, istərsə də `string`, `class`, `array` kimi tiplər hamısı `System.Object` tipindən törəyir.

---

</details>

<details>
<summary>🟦 Value Type – Qiymət Tipi</summary>


- `struct` olaraq təyin olunur  
- **Stack** yaddaşında yaradılır (FILO – First In, Last Out)  
- **Müqayisə** dəyərlə aparılır (`==` ilə müqayisə eyni dəyərdirsə doğrudur)  
- **Kopyalama** zamanı dəyər surəti çıxarılır  
- `new` açarı olmadan da yaradılıb istifadə oluna bilər  
- Təmizlənməsi: scope bitdikdə **avtomatik yaddaşdan silinir**

---

</details>

<details>
<summary>🟪 Reference Type – İstinad Tipi</summary>


- `class` olaraq təyin olunur  
- **Heap** yaddaşında yaradılır  
- **Müqayisə** referens (istinad) üzərindən aparılır (obyektin ünvanı)  
- **Kopyalama** zamanı istinad ötürülür  
- `new` açarı ilə yaradılır  
- Təmizlənməsi: **Garbage Collector** tərəfindən avtomatik silinir

---

</details>

<details>
<summary>📊 Müqayisə Cədvəli</summary>


| Xüsusiyyət         | Value Type                        | Reference Type                      |
|--------------------|-----------------------------------|-------------------------------------|
| Təyinat            | `struct`                          | `class`                             |
| Yaddaş yeri        | Stack                              | Heap                                |
| Müqayisə üsulu     | By value (dəyərlə)                 | By reference (istinadla)            |
| Kopyalama üsulu    | Dəyər surəti                       | İstinad ötürülür                    |
| Yaradılma üsulu    | `new` olmadan da mümkün            | `new` ilə mütləq yaradılır          |
| Yaddaşdan silinmə  | Scope bitdikdə avtomatik           | Garbage Collector ilə avtomatik     |
| Misallar           | `int`, `bool`, `float`, `char`     | `string`, `object`, `class`, `array`|

---

</details>

<details>
<summary>💡 Nümunə</summary>


```csharp
// Value Type
int a = 5;
int b = a;   // b = 5, yeni nüsxə yaradılır

// Reference Type
string name1 = "Nadir";
string name2 = name1; // eyni obyektə istinad edirlər
```

---


</details>
</details>
---
<details>
<summary>Dərs 2</summary>



- Dəyişənlər və adlandırma qaydaları
- `Console` class-ı və metodları
- Typecasting (Tip çevrilməsi)
- Array-lar (birölçülü, çoxölçülü, jagged)
- Range və Index ifadələri
- `switch` operatoru və `enum` tipi

---


<details>
<summary>🧾 Dəyişənlər və Adlandırma Qaydaları</summary>


C# dilində dəyişənlər tipə əsaslanır və aşağıdakı prinsiplərə əsasən adlandırılır:

- Camel Case: `myVariable`, `totalSum`
- Ad aydın və mənalı olmalıdır.
- `@` simvolu ilə C# açar sözləri dəyişən kimi istifadə oluna bilər: `int @class = 5;`

**Misal:**
```csharp
string name = "Nadir";
int age = 30;
var surname = "Zamanov"; // `var` tip avtomatik təyin edilir
```

---

</details>

<details>
<summary>🖥️ `Console` Class-ı və Əsas Metodlar</summary>


| Metod | Təyinatı |
|-------|----------|
| `Write`, `WriteLine` | Mətni ekrana yazır |
| `Read`, `ReadLine`, `ReadKey` | İstifadəçidən məlumat oxuyur |
| `Clear()` | Konsolu təmizləyir |
| `Beep()` | Səs çıxarır |
| `ForegroundColor`, `BackgroundColor` | Mətnin rəngini dəyişir |

**Misal:**
```csharp
Console.WriteLine("Adınızı daxil edin:");
string ad = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Salam, {ad}!");
```

---

</details>

<details>
<summary>🔄 Typecasting – Tip çevrilməsi</summary>


### İki növ var:

- **Implicit (açıq olmayan)** – məlumat itkisi yoxdursa avtomatik çevrilmə
- **Explicit (açıq)** – əl ilə çevrilmə, məlumat itkisi ola bilər

**Misal:**
```csharp
int a = 100;
double b = a; // implicit

double x = 45.67;
int y = (int)x; // explicit

int num = 5;
string s = num.ToString(); // Tipi string-ə çevirmək
```

> C#-da `bool` tipinə digər tiplərdən birbaşa çevrilmə icazəli deyil.

---

</details>

<details>
<summary>🧮 Array-lar</summary>


### Birölçülü Array:
```csharp
int[] arr = {1, 2, 3, 4};
```

### Çoxölçülü Array (2D):
```csharp
int[,] matrix = {
    {1, 2},
    {3, 4}
};
```

### Jagged Array (array of arrays):
```csharp
int[][] jagged = new int[2][];
jagged[0] = new int[] {1, 2};
jagged[1] = new int[] {3, 4, 5};
```

### Faydalı metodlar:
- `Length` – elementlərin ümumi sayı
- `Rank` – ölçülərin sayı (1D: 1, 2D: 2)

---

</details>

<details>
<summary>📐 Range və Index ifadələri (C# 8.0+)</summary>


| Sintaksis | Açıqlama |
|-----------|----------|
| `arr[2..5]` | 2-ci indeksdən 4-cü indeksə qədər |
| `arr[^1]` | Sonuncu element |
| `arr[..3]` | Başdan 3 element |
| `arr[3..]` | 3-dən sona qədər |

**Misal:**
```csharp
int[] nums = {1,2,3,4,5,6};
int[] sliced = nums[2..^1];
Console.WriteLine(nums[^1]); // 6
```

---

</details>

<details>
<summary>🔀 `switch` Operatoru və `enum`</summary>


### `switch`-də istifadə olunan əsas qaydalar:

- `case`-lər unikal olmalıdır
- `break` və ya `return` ilə hər blok bitirilməlidir
- `default` istəyə bağlıdır
- `goto case` digər halda təkrar yönləndirmə edir

**Misal:**
```csharp
enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

int.TryParse(Console.ReadLine(), out int d);
switch ((Days)d)
{
    case Days.Monday:
        Console.WriteLine("Bazar ertəsi");
        break;
    case Days.Sunday:
        Console.WriteLine("Bazar");
        break;
    default:
        Console.WriteLine("Yanlış dəyər");
        break;
}
```
</details>
</details>
---
<details>
 ---   
<summary>Dərs 3</summary>



<details>
<summary>📦 Struct</summary>


### Xüsusiyyətləri:
- `struct` - value type-dir (dəyər tipidir), yəni Stack üzərində yerləşir.
- Struct-lar `class` kimi öz field, property və metodlarına sahib ola bilər.
- Struct-lar miras ala bilməz (`inheritance`), lakin interfeysləri (`interface`) implement edə bilər.
- Struct-lar hər zaman **deep copy** əsasında köçürülür (dəyərlər köçürülür, referens deyil).

### Nümunə:
```csharp
struct Point
{
    public int x;
    public int y;
    public int[] arr;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
        this.arr = new int[] { 25, 5 };
    }
}
```

```csharp
Point p1 = new Point(10, 20);
Point p2 = p1;
p1.arr[0] = 999;
Console.WriteLine(p2.arr[0]); // 999 - amma array reference-dir! DİQQƏT!
```

💡 Struct-ların daxilində referens tip varsa (məsələn, array), bu zaman "deep copy" tam tətbiq olunmur.

---

</details>

<details>
<summary>🧵 String</summary>


### Xüsusiyyətləri:
- `string` C#-də `System.String` tipinə aiddir və immutable-dir (dəyişməzdir).
- Bütün dəyişikliklər yeni obyekt yaradır.
- .NET `intern pool` istifadə edir - eyni string literal-lar bir dəfə yadda saxlanılır.
- Hər dəfə string üzərində dəyişiklik etdikdə yeni obyekt yaradılır və köhnə obyektlər **Garbage Collector** tərəfindən silinməlidir. Bu, yaddaş istifadəsini artırır və performansa təsir edə bilər.

### İstifadə:
```csharp
string str1 = "Hello";
string str2 = new string("Hello".ToCharArray());
Console.WriteLine(str1 == str2);         // true
Console.WriteLine(object.ReferenceEquals(str1, str2)); // false
```

### Faydalı metodlar:
| Metod | Təsviri |
|-------|---------|
| `Length` | Uzunluq |
| `ToUpper()` / `ToLower()` | Böyük / kiçik hərflərlə çevirir |
| `IndexOf(char)` | Simvollar arasında axtarış |
| `Substring(start, length)` | Alt sətrin alınması |
| `Split(char)` | Ayrıcılara görə bölmək |
| `Replace(old, new)` | Əvəz etmə |
| `Trim()` / `TrimStart()` / `TrimEnd()` | Boşluqları təmizləmək |
| `Contains(string)` | Alt sətri yoxlamaq |
| `StartsWith()` / `EndsWith()` | Başlama və bitmə yoxlamaları |

### Nümunə:
```csharp
string word = "Hello, World!";
Console.WriteLine(word.ToUpper());         // HELLO, WORLD!
Console.WriteLine(word.Substring(0, 5));   // Hello
Console.WriteLine(word.Contains("World")); // true
```

---

</details>

<details>
<summary>🔧 StringBuilder</summary>


### Xüsusiyyətləri:
- `StringBuilder` dəyişə bilən string təqdim edir.
- Performans baxımından daha effektivdir, xüsusən çox sayda string birləşməsi zamanı.
- Yaddaşda yalnız bir obyekt saxlanıldığı üçün Garbage Collector-u yükləmir.

### İstifadə:
```csharp
using System.Text;

StringBuilder sb = new StringBuilder("Hi");
sb.Append(" there");
sb.AppendLine("!");
Console.WriteLine(sb.ToString());
```

### Əsas metodlar:
| Metod | Təsviri |
|-------|---------|
| `Append()` | Sonuna əlavə edir |
| `AppendLine()` | Yeni sətrə əlavə edir |
| `Insert(index, value)` | Müəyyən indeksə əlavə edir |
| `Remove(start, length)` | Hissəni silir |
| `Replace(old, new)` | Əvəz edir |
| `Clear()` | Təmizləyir |

### Performans müqayisəsi:
```csharp
string s = "";
for (int i = 0; i < 10000; i++)
{
    s += i.ToString(); // hər dəfə yeni string yaradılır - zəif performans
}

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10000; i++)
{
    sb.Append(i); // effektivdir
}
```

---

</details>

<details>
<summary>🔍 string və StringBuilder müqayisəsi</summary>


| Xüsusiyyət | string | StringBuilder |
|------------|--------|----------------|
| Dəyişə bilirmi? | Xeyr (immutable) | Bəli (mutable) |
| Hər dəyişiklikdə yeni obyekt yaranırmı? | Bəli | Xeyr |
| Performans (çoxlu birləşmə zamanı) | Zəif | Yüksək |
| Garbage Collector yüklənməsi | Artır | Azdır |
| Kod yazmaq rahatlığı | Sadə | Bir qədər daha uzun |

---

</details>

<details>
<summary>✅ Nəticə</summary>

| Tip | Növ | Yerləşmə | Dəyişə bilirmi? | Performans |
|-----|-----|----------|-----------------|------------|
| Struct | Value Type | Stack | Bəli | Yüngül obyektlər üçün ideal |
| string | Reference Type | Heap | Xeyr (immutable) | Kiçik əməliyyatlar üçün normal |
| StringBuilder | Reference Type | Heap | Bəli | Birləşmələr üçün daha sürətli |

---
</details>
</details>
