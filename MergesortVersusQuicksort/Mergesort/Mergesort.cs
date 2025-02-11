namespace MergesortVersusQuicksort.Mergesort;

public static class Mergesort
{
    private static List<int> ExecuteBasicMergesort(List<int> inputValues)
        => BasicMergesort.MergeSort(inputValues);

    private static List<int> ExecuteParameterizedMergesort(List<int> inputValues, bool ascending)
        => ParameterizedMergeSort.MergeSort(inputValues, ascending);

    private static List<int> ExecuteHigherOrderMergesort(List<int> inputValues, Func<int, int, bool> func)
        => HigherOrderMergesort.MergeSort(inputValues, func);
}