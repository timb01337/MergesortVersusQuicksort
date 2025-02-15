﻿namespace MergesortVersusQuicksort.Quicksort;

public static class BasicQuicksort
{
    public static void QuickSort(int[] array, int left, int right)
    {
        if (left >= right) //abort condition for recursion
            return;

        int pivotIndex = Partition(array, left, right); //Partition the array around a pivot
        QuickSort(array, left, pivotIndex - 1); // Recursively sort the elements to the left of the pivot
        QuickSort(array, pivotIndex + 1, right); //recursively sort the elements to the right of the pivot
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivotValue = array[right]; //choose the last element as the pivot
        int boundaryIndex = left - 1; //this index tracks the boundary where elements are smaller than the pivot 

        //iterate over the segment, comparing each element with the pivot
        for (int i = left; i < right; i++)
        {
            //check if the current element is smaller than the pivot
            if (array[i] < pivotValue)
            {
                boundaryIndex++;

                //Swap elements to move the smaller element into the region before boundaryIndex
                (array[boundaryIndex], array[i]) = (array[i], array[boundaryIndex]);
            }
        }
        
        //get the pivots final position
        int pivotPosition = boundaryIndex + 1;
        //swap the pivot with the element just after the "smaller side"
        (array[pivotPosition], array[right]) = (array[right], array[pivotPosition]);

    
        return pivotPosition;  //return the final index of the pivot
    }
}