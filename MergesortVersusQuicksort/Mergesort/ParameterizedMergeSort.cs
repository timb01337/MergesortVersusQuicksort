namespace MergesortVersusQuicksort.Mergesort;

public static class ParameterizedMergeSort
{
    public static List<int> MergeSort(List<int> unsorted, bool ascending)
    {
        if (unsorted.Count <= 1)
            return unsorted; // Base case: return the list if it has only one element

        // Divide the unsorted list into two halves
        var left = new List<int>();
        var right = new List<int>();

        var middle = unsorted.Count / 2;
        for (var i = 0; i < middle; i++) // Split the unsorted list into left
            left.Add(unsorted[i]);
        
        for (var i = middle; i < unsorted.Count; i++) // Split the unsorted list into right
            right.Add(unsorted[i]);
        
        left = MergeSort(left, ascending); //Recursively perform Merge Sort for the left list
        right = MergeSort(right, ascending); //Recursively perform Merge Sort for the right list

        // Merge the sorted halves
        return Merge(left, right, ascending);
    }
    
    
    private static List<int> Merge(List<int> left, List<int> right, bool ascending)
    {
        var result = new List<int>();
        
        while (left.Count > 0 || right.Count > 0) 
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (ascending ? (left.First() <= right.First()) : (left.First() >= right.First())) 
                {
                    result.Add(left.First());
                    left.Remove(left.First()); // Remove the added element from the list
                }
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First()); // Remove the added element from the list
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left.First());
                left.Remove(left.First());
            }
            else if (right.Count > 0)
            {
                result.Add(right.First());
                right.Remove(right.First());
            }
        }

        return result; // Return the merged and sorted list
    }
}