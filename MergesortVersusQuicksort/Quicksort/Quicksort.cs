using System.Diagnostics;
using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

namespace MergesortVersusQuicksort.Quicksort;

public static class Quicksort
{
    public static void RunBasicTests()
    {
        var unsortedIntegers = new int[] { 8, 5, 3, 9, 4, 1, 7, 2, 6, 10 };
        BasicQuicksort.QuickSort(unsortedIntegers, 0, unsortedIntegers.Length - 1);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in unsortedIntegers)
            Console.Write(entry + " ");


        var ascendingIntegers = new int[] { 1,2,3,4,5,6,7,8,9, 10 };
        BasicQuicksort.QuickSort(ascendingIntegers, 0, ascendingIntegers.Length - 1);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in ascendingIntegers)
            Console.Write(entry + " ");


        var descendingIntegers = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        BasicQuicksort.QuickSort(descendingIntegers, 0, descendingIntegers.Length - 1);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in descendingIntegers)
            Console.Write(entry + " ");
    }

    public static void RunAdvancedTests(int numberOfElements)
    {
        var unsortedIntegers1 = SortingData.GenerateData(numberOfElements, SortingTypes.Random).ToArray();
        var unsortedIntegers2 = SortingData.GenerateData(numberOfElements, SortingTypes.Random).ToArray();
        var ascendingIntegers = SortingData.GenerateData(numberOfElements, SortingTypes.Ascending).ToArray();
        var descendingIntegers = SortingData.GenerateData(numberOfElements, SortingTypes.Descending).ToArray();

        //JIT warmup
        BasicQuicksort.QuickSort(unsortedIntegers1.ToArray(), 0, unsortedIntegers1.Length - 1);
        
         var sw1 = Stopwatch.StartNew();
         BasicQuicksort.QuickSort(unsortedIntegers2, 0, unsortedIntegers2.Length - 1);
         sw1.Stop();
         Console.WriteLine($"Executed quicksort on {numberOfElements} random entries in {sw1.ElapsedMilliseconds} ms.");
        
        var sw2 = Stopwatch.StartNew();
        BasicQuicksort.QuickSort(ascendingIntegers, 0, ascendingIntegers.Length - 1);
        sw2.Stop();
        Console.WriteLine($"Executed quicksort on {numberOfElements} ascending entries in {sw2.ElapsedMilliseconds} ms.");
        
        var sw3 = Stopwatch.StartNew();
        BasicQuicksort.QuickSort(descendingIntegers, 0, descendingIntegers.Length - 1);
        sw3.Stop();
        Console.WriteLine($"Executed quicksort on {numberOfElements} descending entries in {sw3.ElapsedMilliseconds} ms.");
    }

}