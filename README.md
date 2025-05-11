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

---

## Başlamaq üçün

```bash
dotnet new console -n HelloDotNet
cd HelloDotNet
dotnet run
```

> `.NET` ilə proqramlaşdırmaya başlamaq çox asandır — sadəcə `dotnet` komandasından istifadə et!
