namespace MergesortVersusQuicksort.Mergesort;


public static class HigherOrderMergesort
{
    public static void MergeSort(List<int> list, Func<int, int, bool> compareFunc)
    {
        if (list.Count <= 1) //abort condition for recursion
            return; 

        //split the list into a right and a left part
        var left = new List<int>();
        var right = new List<int>();
        
        for (int i = 0; i < list.Count / 2; i++)
            left.Add(list[i]);
        
        for (int i = list.Count / 2; i < list.Count; i++)
            right.Add(list[i]);
        
        MergeSort(left, compareFunc); //recursively continue splitting the left list
        MergeSort(right, compareFunc); //recursively continue splitting the right list
        
        Merge(list, left, right, compareFunc); //when splitting is done, sort and merge the two halves
    }

    private static void Merge(List<int> list, List<int> left, List<int> right, Func<int, int, bool> compareFunc)
    {
        list.Clear(); //the original list gets cleared, so it can hold the sorted and merged result
        
        while (left.Count > 0 && right.Count > 0) //loop as long as left AND right contain elements
        {
            if (compareFunc(left[0], right[0]))
            {
                list.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                list.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        
        while (left.Count > 0) //clean up the left over elements from the left list (if there are any)
        {
            list.Add(left[0]);
            left.RemoveAt(0);
        }
        
        while (right.Count > 0) //clean up the left over elements from the right list (if there are any)
        {
            list.Add(right[0]);
            right.RemoveAt(0);
        }
    }
}