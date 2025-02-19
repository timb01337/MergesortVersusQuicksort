using MergesortVersusQuicksort.Data;

namespace MergesortVersusQuicksort.Test;

public class TestDataGeneration
{
    [Fact]
    public void ShouldProduceListWith500Entries()
    {
        var data = SortingData.GenerateData(500, SortingTypes.Random);
        Assert.Equal(500, data.Count);
    }

    [Fact]
    public void ShouldProduceAscendingList()
    {
        var data = SortingData.GenerateData(100, SortingTypes.Ascending);

        var listIsAscending = true;

        for (var i = 0; i < data.Count; i++)
        {
            if (data[i] != i)
            {
                listIsAscending = false;
                break;
            }
        }
        
        Assert.True(listIsAscending);
    }
    
    [Fact]
    public void ShouldProduceDescendingList()
    {
        var data = SortingData.GenerateData(100, SortingTypes.Descending);

        var listIsDescending = true;

        for (var i = 0; i < data.Count; i++)
        {
            var val = data.Count - 1 - i;
            
            if (data[i] != val)
            {
                listIsDescending = false;
                break;
            }
        }
        
        Assert.True(listIsDescending);
    }
}