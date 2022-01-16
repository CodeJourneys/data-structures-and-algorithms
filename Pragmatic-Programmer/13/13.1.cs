// Given an array of positive numbers, write a function that returns the greatest product of any three numbers.
// The approach of using three nested loops would clock in at O(N^3), which is very slow.
// Use sorting to implement the function in a way that it computes at O(N log N) speed.
// (There are even faster implementations, but we're focusing on using sorting as a technique to make code faster.)

public class ThirteenDotOne
{
    public int GetGreatestProductOfThree(int[] arr)
    {
        validateArray(arr, 0, 0);

        // edge case for arrays less than 3
        if(arr.Length < 3)
        {
            int result = 1;

            for(var i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }

            return result;
        }

        // sort array - O(N log N) time
        quicksortArray(arr, 0, arr.Length - 1);

        // return max elements - O(1) time
        return arr[arr.Length - 1] * arr[arr.Length - 2] * arr[arr.Length - 3];
    }

    private void quicksortArray<T>(T[] arr, int leftIndex, int rightIndex)
    {
        if(rightIndex - leftIndex <= 0)
            return;
        
        var pivotIndex = getSortPivot(arr, leftIndex, rightIndex);

        quicksortArray(arr, leftIndex, pivotIndex - 1);
        quicksortArray(arr, pivotIndex + 1, rightIndex);
    }

    private int getSortPivot<T>(T[] arr, int leftPointer, int rightPointer)
    {
        var pivotIndex = rightPointer;

        var pivot = arr[pivotIndex];

        rightPointer -= 1;

        while(true)
        {
            while(arr[leftPointer] < pivot)
            {
                leftPointer += 1;
            }

            while(arr[rightPointer] > pivot)
            {
                rightPointer -= 1;
            }

            if(leftPointer >= rightPointer)
            {
                break;
            }
            else
            {
                swapArrayValues(arr, leftPointer, rightPointer);
                leftPointer++;
            }
        }

        swapArrayValues(arr, leftPointer, pivotIndex);
        return leftPointer;
    }

    private void swapArrayValues<T>(T[] arr, int left, int right)
    {
        validateArray(arr, left, right);

        T temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
    }

    private void validateArray<T>(T[] arr, int? pointerOne = null, int? pointerTwo = null)
    {
        // edge case for array not defined
        if(arr == null || arr.Length < 1)
        {
            throw new System.ArgumentException($"{nameof(arr)} must be defined");
        }

        // edge case for pointers not in array range
        if((pointerOne != null && (pointerOne < 0 || pointerOne > arr.Length)) ||
        (pointerTwo != null && (pointerTwo < 0 || pointerTwo > arr.Length)))
        {
            throw new System.IndexOutOfRangeException();
        }
    }
}