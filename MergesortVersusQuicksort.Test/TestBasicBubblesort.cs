using MergesortVersusQuicksort.Bubblesort;
using MergesortVersusQuicksort.Data;

namespace MergesortVersusQuicksort.Test;

public class TestBasicBubblesort
{
    [Fact]
    public void ShouldProduceAscendingSortedListFromRandom()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random).ToArray();
        BasicBubblesort.BubbleSort(data);

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
        BasicBubblesort.BubbleSort(data);

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
        BasicBubblesort.BubbleSort(data);

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