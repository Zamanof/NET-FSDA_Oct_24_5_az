<details>
<summary>Dərs 1</summary>

</details>

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

...

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
