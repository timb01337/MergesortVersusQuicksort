using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;

namespace MergesortVersusQuicksort.Test;

public class TestBasicMergeSort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random);
        var suspiciousSortedData = BasicMergesort.MergeSort(data);
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
    public void ShouldProduceAscendingSortedListFromAscending()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Ascending);
        var suspiciousSortedData = BasicMergesort.MergeSort(data);
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
    public void ShouldProduceAscendingSortedListFromDescending()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Descending);
        var suspiciousSortedData = BasicMergesort.MergeSort(data);
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
}