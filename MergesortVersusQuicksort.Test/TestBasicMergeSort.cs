using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

namespace MergesortVersusQuicksort.Test;

public class TestBasicMergeSort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random);
        BasicMergesort.MergeSort(data);
        
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
    public void ShouldProduceAscendingSortedListFromAscending()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Ascending);
        BasicMergesort.MergeSort(data);
        
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
    public void ShouldProduceAscendingSortedListFromDescending()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Descending);
        BasicMergesort.MergeSort(data);
        
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
}