using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

ValueTypePerfTest();


/// <summary>
/// method for testing the performance of generic 
/// and non-generic list 
/// </summary>
void ValueTypePerfTest()
{
    const int COUNT = 10_000_000;
    // The OperationTimer object is created before 
    // the collection is used, after its use is 
    // completed, displays the time spent for 
    // working with the collection 
    using (new OperationTimer("List"))
    {
        // use of a generic list
        List<int> list = new List<int>(COUNT);
        Console.WriteLine(GC.GetGeneration(list));
        for (int n = 0; n < COUNT; n++)
        {
            list.Add(n);
            int x = list[n];
        }
        Console.WriteLine(GC.GetGeneration(list));
        list = null; // for guaranteed execution 
                     // of garbage collection
    }
    using (new OperationTimer("ArrayList"))
    {
        // use of a non-generic collection
        ArrayList array = new ArrayList();
        Console.WriteLine(GC.GetGeneration(array));
        int ch = 0;
        for (int n = 0; n < COUNT; n++)
        {
            array.Add(n); // boxing
            int x = (int)array[n]; // unboxing
            if (GC.GetGeneration(array) == 1 && ch == 0)
            {
                Console.WriteLine($"{n}-th iteration : Managed heap generation {GC.GetGeneration(array)}");
                ch++;
            }
            if (GC.GetGeneration(array) == 2 && ch == 1)
            {
                Console.WriteLine($"{n}-th iteration : Managed heap generation {GC.GetGeneration(array)}");
                ch++;
            }

        }
        array = null; // for guaranteed execution 
                      // of garbage collection
    }
}


/// <summary>
/// The auxiliary class for profiling the code section
/// performs runtime measurements
/// and counts the number of garbage collections
/// </summary>
sealed class OperationTimer : IDisposable
{
    long _startTime;
    string _text;
    int _collectionCount;
    public OperationTimer(string text)
    {
        PrepareForOperation();
        _text = text;
        // the number of garbage collections that 
        // have been completed so far is saved
        _collectionCount = GC.CollectionCount(0);
        // the initial time is preserved
        _startTime = Stopwatch.GetTimestamp();
    }
    /// <summary>
    /// called when the object is destroyed
    /// Outputs:
    /// The value of the time elapsed from the moment 
    /// of creation of the object
    /// to the time it was deleted, the number 
    /// of garbage collections performed during 
    /// this time
    /// </summary>
    public void Dispose()
    {
        Console.WriteLine($"{_text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} seconds(garbage collections {GC.CollectionCount(0) - _collectionCount})");

    }
    /// <summary>
    /// The method deletes all unused objects
    /// This is needed for maintaining 
    /// the experimental integrity,
    /// i.e.So that garbage collection occurs only 
    /// for objects that will be created in 
    /// the profiled code block
    ///</summary>
    private static void PrepareForOperation()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}
