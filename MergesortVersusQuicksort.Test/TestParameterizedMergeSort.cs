using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

namespace MergesortVersusQuicksort.Test;

public class TestParameterizedMergeSort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random);
        var suspiciousSortedData = ParameterizedMergeSort.MergeSort(data, true);
        var correctlySortedData = data.Order().ToList();

        var correctlySorted = true;

        for (int i = 0; i < data.Count; i++)
        {
            if (suspiciousSortedData[i] != correctlySortedData[i])
            {
                correctlySorted = false;
                break;
            }
        }
        
        Assert.True(correctlySorted);

    }
    
    [Fact]
    public void ShouldProduceDescendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random);
        var suspiciousSortedData = ParameterizedMergeSort.MergeSort(data, false);
        var correctlySortedData = data.OrderDescending().ToList();

        var correctlySorted = true;

        for (int i = 0; i < data.Count; i++)
        {
            if (suspiciousSortedData[i] != correctlySortedData[i])
            {
                correctlySorted = false;
                break;
            }
        }
        
        Assert.True(correctlySorted);

    }
}