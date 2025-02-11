namespace MergesortVersusQuicksort.Quicksort;


public static class BasicQuicksort
{
    // Method to perform Quick Sort on an array
    private static void QuickSort(int[] arr, int left, int right)
    {
        // Check if there are elements to sort
        if (left < right)
        {
            // Find the pivot index
            int pivot = Partition(arr, left, right);

            // Recursively sort elements on the left and right of the pivot
            if (pivot > 1)
                QuickSort(arr, left, pivot - 1);
            
            if (pivot + 1 < right)
                QuickSort(arr, pivot + 1, right);
        }
    }

    // Method to partition the array
    private static int Partition(int[] arr, int left, int right)
    {
        // Select the pivot element
        int pivot = arr[left];

        // Continue until left and right pointers meet
        while (true)
        {
            // Move left pointer until a value greater than or equal to pivot is found
            while (arr[left] < pivot)
                left++;
            
            // Move right pointer until a value less than or equal to pivot is found
            while (arr[right] > pivot)
                right--;
            
            // If left pointer is still smaller than right pointer, swap elements
            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                // Return the right pointer indicating the partitioning position
                return right;
            }
        }
    }
}