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

internal class GarbageHelper
{
    public void MakeGarbage()
    {
        for (int i = 0; i < 1000; i++)
        {
            Person person = new();
        }
    }
}