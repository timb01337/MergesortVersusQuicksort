using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

var randomData = SortingData.GenerateData(10000, SortingTypes.Random);
var ascendingData = SortingData.GenerateData(10000, SortingTypes.Ascending);
var descendingData = SortingData.GenerateData(10000, SortingTypes.Descending);

var sort1 = BasicMergesort.MergeSort(ascendingData);
var sort2 = ParameterizedMergeSort.MergeSort(ascendingData, false);

