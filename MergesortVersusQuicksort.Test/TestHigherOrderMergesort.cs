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
        
        HigherOrderMergesort.MergeSort(data, comparisonFunction);
        
        var correctlySorted = true;

        for (int i = 0; i < data.Count - 1; i++)
        {
            if (data[i] > data[i + 1])
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
        
        HigherOrderMergesort.MergeSort(data, comparisonFunction);
        
        var correctlySorted = true;

        for (int i = 0; i < data.Count - 1; i++)
        {
            if (data[i] < data[i + 1])
            {
                correctlySorted = false;
                break;
            }
        }
        
        Assert.True(correctlySorted);
    }
}