# Dərs 1
# .NET Arxitekturası və Komponentləri

**.NET** — Microsoft tərəfindən yaradılmış, fərqli dillərdə və platformalarda proqramlaşdırma üçün vahid ekosistemdir.

> `.NET Framework` yalnız Windows üçündür  
> `.NET Core / .NET 5+` açıq mənbəli, modul əsaslı və çoxplatformalı müasirləşdirilmiş versiyadır

---

## 1. CLR – Common Language Runtime

`.NET` proqramlarının əsas işləmə mühərrikidir.

**Əsas funksiyaları:**
- IL (Intermediate Language) → maşın koduna çevrilmə (JIT)
- Yaddaş idarəsi (`Garbage Collector`)
- Təhlükəsizlik və istisna (exception) idarəsi
- Tip yoxlaması və çoxaxınlılıq (threads)

> `.NET Core` üçün bu komponent `CoreCLR` adlanır.

---

## 2. FCL – Framework Class Library

`.NET` üçün **standart siniflər toplusudur**:

- `System.IO` – fayllarla işləmə  
- `System.Net` – şəbəkə  
- `System.Linq` – verilənlər üzərində sorğular  
- `System.Threading` – paralel proqramlaşdırma  
- `System.Text.Json` – JSON işləmə

> `.NET Core`-da bu kitabxana `CoreFX` adlanır.

---

## 3. BCL – Base Class Library

`FCL`-in əsas hissəsidir, bazadakı sinifləri əhatə edir:

```csharp
string name = "Nadir";
List<int> nums = new List<int> { 1, 2, 3 };
DateTime now = DateTime.Now;
```

---

## 4. CTS – Common Type System

Bütün .NET dilləri üçün **ümumi tip sistemi** yaradır.

| C#       | VB.NET   | CTS Tipi        |
|----------|----------|-----------------|
| `int`    | `Integer`| `System.Int32`  |
| `string` | `String` | `System.String` |
| `bool`   | `Boolean`| `System.Boolean`|

---

## 5. CLS – Common Language Specification

Müxtəlif dillərin bir-biri ilə uyğun işləməsi üçün **qaydalar toplusudur**.  
CLS uyğun siniflər bütün .NET dillərində istifadə oluna bilər.

---

## 6. MSIL / CIL – Aralıq Kod

`.NET` kodu əvvəlcə **MSIL** (Microsoft Intermediate Language) və ya **CIL**-ə çevrilir.  
Sonra bu kod JIT vasitəsilə maşın koduna çevrilir və icra olunur.

---

## 7. JIT – Just-In-Time Compiler

**JIT kompilyatoru**, MSIL → maşın kodu çevirir, proqram icra olunanda.

> `.NET Core`-da **RyuJIT** adlı sürətli və optimallaşdırılmış versiyası istifadə olunur.

---

## 8. Garbage Collector (GC)

Yaddaşda istifadə olunmayan obyektləri **avtomatik təmizləyir**:

- Yaddaş sızmalarının qarşısı alınır  
- Əllə `delete` yazmağa ehtiyac yoxdur

---

## 9. Metadata və Reflection

`.dll` və `.exe` fayllarında **sinif və metodlar haqqında məlumat** saxlanır.

```csharp
Type t = typeof(MyClass);
MethodInfo[] methods = t.GetMethods();
```

---

## 10. NuGet – Paket İdarəetməsi

`.NET` üçün rəsmi **paket meneceri**:

```bash
dotnet add package Newtonsoft.Json
```

- On minlərlə açıq mənbə paketi
- Öz paketlərini yaratmaq mümkündür

---

## 11. .NET CLI – Komanda Sətiri Vasitəsi

```bash
dotnet new console -n HelloApp
dotnet run
```

Layihə yaratmaq, test, qurmaq və yayımlamaq üçün istifadə olunur.

---

## 12. SDK – Software Development Kit

`.NET SDK` tərkibinə daxildir:

- Kompilyatorlar (`Roslyn`)  
- `dotnet` CLI  
- Kitabxanalar (BCL, FCL)  
- Şablonlar və əlavə vasitələr

---

## 13. ASP.NET Core

Krosplatformalı və yüksək performanslı **veb çərçivə**:

- REST API-lər, Web Apps, SignalR  
- Minimal API, Blazor, Razor Pages

---

## 14. Entity Framework Core (EF Core)

Verilənlər bazası ilə işləmək üçün **ORM vasitəsidir**.

```csharp
var users = db.Users.Where(u => u.IsActive).ToList();
```

- SQL Server, PostgreSQL, SQLite dəstəyi  
- Migration, LINQ, AsNoTracking

---

## 15. RyuJIT

`.NET Core` üçün **yeni nəsil JIT kompilyatorudur**:

- SIMD və ARM dəstəyi  
- Yüksək performans  
- Ağıllı optimallaşdırma

---

## Müqayisə Cədvəli

| Xüsusiyyət     | .NET Framework  | .NET Core / .NET 5+      |
|----------------|------------------|---------------------------|
| Platforma       | Yalnız Windows   | Windows, Linux, macOS     |
| Açıq mənbə      | Xeyr             | Bəli                      |
| Modulyarlıq     | Az               | Yüksək                    |
| Performans      | Orta             | Yüksək                    |
| Aktiv inkişaf   | Zəif             | Aktiv                     |

# C# Top-Level Statements və Data Type-lar

---

## 🔹 Top-Level Statements nədir?

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

## 🔸 C# Tip Sistemi

C#-da bütün tiplər `object`-dən törəyir.

```csharp
int number = 5;
object obj = number; // boxing
```

---

## 🟦 Value Types (Qiymət Tipləri)

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

## 🟪 Reference Types (İstinad Tipləri)

| Tip         | System Tipi        | Xüsusiyyətlər                      |
|-------------|--------------------|------------------------------------|
| `string`    | System.String      | Unicode simvol sırası, immutable  |
| `object`    | System.Object      | Bütün tiplərin kökü               |
| `dynamic`   | System.Object      | Runtime tip yoxlanışı              |
| `class`, `interface`, `array` və s. | - | Heap-də saxlanır və GC tərəfindən idarə olunur |

📌 Reference type-lar `new` açarı ilə yaradılır və **heap** yaddaşda yerləşir.

---

## ✅ Value vs Reference Types

| Xüsusiyyət     | Value Type                   | Reference Type               |
|----------------|------------------------------|------------------------------|
| Yaradılma      | `struct`                     | `class`                      |
| Yaddaş         | Stack                        | Heap                         |
| Nümunə         | `int`, `bool`, `double`      | `string`, `object`, `array`  |
| Copy davranışı | Dəyər kopyalanır             | İstinad (referans) kopyalanır|
| Silinmə        | Scope bitdikdə silinir       | Garbage Collector tərəfindən |

---

## 💡 Nümunələr

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

## 📌 Nəticə

C# tip sistemi güclü və təhlükəsizdir. Bütün tiplər `object`-dən törəyir və onlar stack və heap-də fərqli şəkildə idarə olunur. `Top-Level Statements` isə proqram yazmağı daha da sadələşdirir.

---
