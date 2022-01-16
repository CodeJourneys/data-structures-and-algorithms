// without sorting - O(N)

int? findMissingNumber(int[] array)
{
    HashSet<int> numSet = new HashSet<int>();

    for (var i = 0; i < array.length; i++)
    {
        numSet.Add(array[i]);    
    }

    for(var i = 0; i < array.Length; i++)
    {
        if(!numSet.Contains(i))
        {
            return i;
        }
    }

    return null;
}

// with sorting - O(N log N)

int? findMissingNumber(int[] arr)
{
    quicksort(arr, 0, arr.Length - 1);

    for(var i = 0; i < arr.Length; i++)
    {
        if(arr[i] != i)
        {
            return i;
        }
    }

    return null;
}

void quicksort<T>(T[] arr, int left, int right)
{
    if(right - left <= 0)
        return;

    var pivotIndex = partition(arr, left, right);

    quicksort(arr, left, pivotIndex -1);
    quicksort(arr, pivotIndex + 1, right);
}

int partition<T>(T[] arr, int left, int right)
{
    var pivotIndex = right;

    var pivot = arr[pivotIndex];

    while(true)
    {
        while(arr[left] < pivot)
        {
            left++;
        }

        while(arr[right] > pivot)
        {
            right--;
        }

        if(left >= right)
        {
            break;
        }
        else
        {
            swapArrayItems(arr, left, right);
            left++;
        }
    }

    swapArrayItems(arr, left, right);
    return left;
}

voit swapArrayItems<T>(T[] arr, int left, int right)
{
    T temp = arr[left];
    arr[left] = arr[right];
    arr[right] = temp;
}