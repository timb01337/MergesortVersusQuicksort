using MergesortVersusQuicksort.Data;
using MergesortVersusQuicksort.Quicksort;

namespace MergesortVersusQuicksort.Test;

public class TestParameterizedQuicksort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random).ToArray();
        ParameterizedQuicksort.QuickSort(data, 0, data.Length - 1, true);

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
    public void ShouldProduceDescendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random).ToArray();
        ParameterizedQuicksort.QuickSort(data, 0, data.Length - 1, false);
        var correctlySorted = true;

        for (int i = 0; i < data.Length - 1; i++)
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