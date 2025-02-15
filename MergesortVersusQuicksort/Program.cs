using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;
using MergesortVersusQuicksort.Quicksort;
//basic experiments

//var unsortedIntegers = new int[] { 8, 5, 3, 9, 4, 1, 7, 2, 6, 10 };

var unsortedIntegers = new int[] { 3, 5, 1, 6, 7, 2, 4 };

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



//advanced experiments

var randomData = SortingData.GenerateData(10000, SortingTypes.Random);
var ascendingData = SortingData.GenerateData(10000, SortingTypes.Ascending);
var descendingData = SortingData.GenerateData(10000, SortingTypes.Descending);
















