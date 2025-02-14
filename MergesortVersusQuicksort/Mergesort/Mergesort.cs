namespace MergesortVersusQuicksort.Mergesort;

public static class Mergesort
{
    private static void ExecuteBasicMergesort(List<int> inputValues)
        => BasicMergesort.MergeSort(inputValues);

    private static void ExecuteParameterizedMergesort(List<int> inputValues, bool ascending)
        => ParameterizedMergeSort.MergeSort(inputValues, ascending);

    private static void ExecuteHigherOrderMergesort(List<int> inputValues, Func<int, int, bool> func)
        => HigherOrderMergesort.MergeSort(inputValues, func);
}