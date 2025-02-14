using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

//basic experiments

var unsortedIntegers = new List<int> { 8, 5, 3, 9, 4, 1, 7, 2, 6, 10 };
BasicMergesort.MergeSort(unsortedIntegers);

//prints out: 1 2 3 4 5 6 7 8 9 10
foreach (var entry in unsortedIntegers)
    Console.Write(entry + " ");


var ascendingIntegers = new List<int> { 1,2,3,4,5,6,7,8,9, 10 };
BasicMergesort.MergeSort(ascendingIntegers);

//prints out: 1 2 3 4 5 6 7 8 9 10
foreach (var entry in ascendingIntegers)
    Console.Write(entry + " ");


var descendingIntegers = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
BasicMergesort.MergeSort(descendingIntegers);

//prints out: 1 2 3 4 5 6 7 8 9 10
foreach (var entry in descendingIntegers)
    Console.Write(entry + " ");



//advanced experiments

var randomData = SortingData.GenerateData(10000, SortingTypes.Random);
var ascendingData = SortingData.GenerateData(10000, SortingTypes.Ascending);
var descendingData = SortingData.GenerateData(10000, SortingTypes.Descending);












