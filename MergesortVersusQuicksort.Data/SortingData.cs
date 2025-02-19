namespace MergesortVersusQuicksort.Data;

public static class SortingData
{
    public static List<int> GenerateData(int n, SortingTypes sortingType)
    {
        var generatedData = new List<int>();
        
        for (var i = 0; i < n; i++)
        {
            switch (sortingType)
            {
                case SortingTypes.Random:
                    var random = new Random();
                    generatedData.Add(random.Next(n * -1, n));
                    break;
                case SortingTypes.Ascending:
                    generatedData.Add(i);
                    break;
                case SortingTypes.Descending:
                    generatedData.Add(n - 1 - i);
                    break;
                default:
                    break;
            }    
        }
        
        return generatedData;
    }
}