namespace MergesortVersusQuicksort.Data;

public static class SortingData
{
    //optional parameters rangeFrom and rangeTo are only used for random number generation
    public static List<int> GenerateData(int n, SortingTypes sortingType, int rangeFrom = 0, int rangeTo = 10000)
    {
        var generatedData = new List<int>();
        
        for (var i = 0; i < n; i++)
        {
            switch (sortingType)
            {
                case SortingTypes.Random:
                    var random = new Random();
                    generatedData.Add(random.Next(rangeFrom, rangeTo));
                    break;
                case SortingTypes.Ascending:
                    generatedData.Add(i);
                    break;
                case SortingTypes.Descending:
                    generatedData.Add(i);
                    break;
                default:
                    break;
            }    
        }
        
        return generatedData;
    }
}