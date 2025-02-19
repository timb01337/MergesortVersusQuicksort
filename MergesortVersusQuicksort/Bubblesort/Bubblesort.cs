using System.Diagnostics;
using MergesortVersusQuicksort.Data;

namespace MergesortVersusQuicksort.Bubblesort;

public static class Bubblesort
{
    public static void RunBasicTests()
    {
        var unsortedIntegers = new int[] { 8, 5, 3, 9, 4, 1, 7, 2, 6, 10 };
        BasicBubblesort.BubbleSort(unsortedIntegers);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in unsortedIntegers)
            Console.Write(entry + " ");


        var ascendingIntegers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        BasicBubblesort.BubbleSort(ascendingIntegers);
        //prints out: 1 2 3 4 5 6 7 8 9 10
        foreach (var entry in ascendingIntegers)
            Console.Write(entry + " ");


        var descendingIntegers = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        BasicBubblesort.BubbleSort(descendingIntegers);
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
        BasicBubblesort.BubbleSort(unsortedIntegers1);

        var sw1 = Stopwatch.StartNew();
        BasicBubblesort.BubbleSort(unsortedIntegers2);
        sw1.Stop();
        Console.WriteLine($"Executed bubblesort on {numberOfElements} random entries in {sw1.ElapsedMilliseconds} ms.");

        var sw2 = Stopwatch.StartNew();
        BasicBubblesort.BubbleSort(ascendingIntegers);
        sw2.Stop();
        Console.WriteLine($"Executed bubblesort on {numberOfElements} ascending entries in {sw2.ElapsedMilliseconds} ms.");

        var sw3 = Stopwatch.StartNew();
        BasicBubblesort.BubbleSort(descendingIntegers);
        sw3.Stop();
        Console.WriteLine($"Executed bubblesort on {numberOfElements} descending entries in {sw3.ElapsedMilliseconds} ms.");
    }
}