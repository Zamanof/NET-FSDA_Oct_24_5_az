// Garbage collector
/*
 1. Stack - FILO prinsipi ile ishleyir. Gorunme zonasi bitdiyi zaman
    obyekt stack-den avtomatik olaraq silinir

 2. Heap
        - Managed Heap
            * Generation 0
            * Generation 1
            * Generation 2
        Heap-de yaradilan obyektlerin silinmesine GarbageCollector cavabdehdir
        
        - LOH (Large Object Heap) : 85000 byte-dan boyuk olan obyektler bu heap-de yaranir

        - Pinned Heap: Garbage Collector terefinden obyektin yeri deyishdirile bilmir.
                      Adeten unmanaged code ile ishleyerken istifade olunur.

        - Unmanaged Heap  
*/

//Console.WriteLine(GC.MaxGeneration);
GarbageHelper garbageHelper = new();
//garbageHelper.MakeGarbage();
//Console.WriteLine($"Genereation {GC.GetGeneration(garbageHelper)}");
//Console.WriteLine($"Memory {GC.GetTotalMemory(false)} bytes");
//GC.Collect();
//Console.WriteLine($"Genereation {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Genereation {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//GC.Collect();
//Console.WriteLine($"Genereation {GC.GetGeneration(garbageHelper)}");
var genNumber = 0;

for (int i = 1; i < 1_000_000; i++)
{
    garbageHelper.MakeGarbage();
    if (genNumber != GC.GetGeneration(garbageHelper))
    {
        Console.WriteLine($"{i * 1000} - Generation {GC.GetGeneration(garbageHelper)}");
        genNumber++;
    }
}
Console.WriteLine(GC.CollectionCount(0));
Console.WriteLine(GC.CollectionCount(0) + GC.CollectionCount(1));