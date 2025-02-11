using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

namespace MergesortVersusQuicksort.Test;

public class TestHigherOrderMergesort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random);

        Func<int, int, bool> comparisonFunction = (a, b) => a < b;
        
        var suspiciousSortedData = HigherOrderMergesort.MergeSort(data, comparisonFunction);
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

        Func<int, int, bool> comparisonFunction = (a, b) => a > b;
        
        var suspiciousSortedData = HigherOrderMergesort.MergeSort(data, comparisonFunction);
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