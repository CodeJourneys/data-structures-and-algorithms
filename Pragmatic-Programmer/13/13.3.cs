// Write three different implementations of a function that finds the greatest number within an array.
// Write one function that is O(N^2), one that is O(N log N), and one that is O(N).


// O(N^2)

int findGreatestNumber_ExponentialTime(int[] arr)
{
    bool isMaxValue = true;

    for(var i = 0; i < arr.Length; i++)
    {
        isMaxValue = true;
        for(var j = 0; j < arr.Length; j++)
        {
            if(arr[i] < arr[j])
            {
                isMaxValue = false;
            }
        }

        if(isMaxValue)
        {
            return arr[i];
        }
    }
    
    // default value if nothing was found
}

// O(N log N)

int findGreatestNumber_LogTime(int[] arr)
{
    // sort array
    // return largest number
    
    Array.Sort(arr);
    return arr[arr.Length-1];
}

// O(N)

int findGreatestNumber_LinearTime(int[] arr)
{
    // validate that arr is not null or empty

    int max = arr[0];

    for(var i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}