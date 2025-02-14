using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

namespace MergesortVersusQuicksort.Test;

public class TestParameterizedMergeSort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random);
        ParameterizedMergeSort.MergeSort(data, true);
       
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
        ParameterizedMergeSort.MergeSort(data, false);
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