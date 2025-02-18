using System.Diagnostics;
using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Quicksort;

namespace MergesortVersusQuicksort.Mergesort;

public static class Mergesort
{
    public static void RunBasicTests()
    {
        var unsortedIntegers = new List<int> { 8, 5, 3, 9, 4, 1, 7, 2, 6, 10 };
        BasicMergesort.MergeSort(unsortedIntegers);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in unsortedIntegers)
            Console.Write(entry + " ");


        var ascendingIntegers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        BasicMergesort.MergeSort(ascendingIntegers);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in ascendingIntegers)
            Console.Write(entry + " ");


        var descendingIntegers = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        BasicMergesort.MergeSort(unsortedIntegers);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in descendingIntegers)
            Console.Write(entry + " ");
    }

    public static void RunAdvancedTests(int numberOfElements)
    {
        var unsortedIntegers1 = SortingData.GenerateData(numberOfElements, SortingTypes.Random);
        var unsortedIntegers2 = SortingData.GenerateData(numberOfElements, SortingTypes.Random);
        var ascendingIntegers = SortingData.GenerateData(numberOfElements, SortingTypes.Ascending);
        var descendingIntegers = SortingData.GenerateData(numberOfElements, SortingTypes.Descending);

        //JIT warmup
        BasicMergesort.MergeSort(unsortedIntegers1);
        
        var sw1 = Stopwatch.StartNew();
        BasicMergesort.MergeSort(unsortedIntegers2);
        sw1.Stop();
        Console.WriteLine($"Executed mergesort on {numberOfElements} random entries in {sw1.ElapsedMilliseconds} ms.");
        
        var sw2 = Stopwatch.StartNew();
        BasicMergesort.MergeSort(ascendingIntegers);
        sw2.Stop();
        Console.WriteLine($"Executed mergesort on {numberOfElements} ascending entries in {sw2.ElapsedMilliseconds} ms.");
        
        var sw3 = Stopwatch.StartNew();
        BasicMergesort.MergeSort(descendingIntegers);
        sw3.Stop();
        Console.WriteLine($"Executed mergesort on {numberOfElements} descending entries in {sw3.ElapsedMilliseconds} ms.");
    }
}