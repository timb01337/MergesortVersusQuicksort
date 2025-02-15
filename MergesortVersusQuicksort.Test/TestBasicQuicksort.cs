using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Mergesort;
using MergesortVersusQuicksort.Quicksort;

namespace MergesortVersusQuicksort.Test;

public class TestBasicQuicksort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random).ToArray();
        BasicQuicksort.QuickSort(data, 0, data.Length - 1);

        var correctlySorted = true;

        for (int i = 0; i < data.Length - 1; i++)
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
        var data = SortingData.GenerateData(500, SortingTypes.Ascending).ToArray();
        BasicQuicksort.QuickSort(data, 0, data.Length - 1);

        var correctlySorted = true;

        for (int i = 0; i < data.Length - 1; i++)
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
        var data = SortingData.GenerateData(500, SortingTypes.Descending).ToArray();
        BasicQuicksort.QuickSort(data, 0, data.Length - 1);

        var correctlySorted = true;

        for (int i = 0; i < data.Length - 1; i++)
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