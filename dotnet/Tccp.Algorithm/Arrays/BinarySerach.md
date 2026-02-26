# Binary Search
## _Binary search in a sorted array._

```
public static int BinarySearch(int[] arr, int size, int value)
{
    int mid;
    int low = 0;
    int high = size - 1;
    while (low <= high)
    {
        mid = low + (high - low) / 2; // To avoid the overflow
        if (arr[mid] == value)
        {
            return mid;
        }
        else if (arr[mid] < value)
        {
            low = mid + 1;
        }
        else
        {
            high = mid - 1;
        }
    }
    return -1;
}
```
1. First step, cut in a half to reduce the serach space
2. Compare the value we are searching with the middle value. If both values are equal then we return the value that middle index
3. if the this value is smallwer than the middle value, we are going to search he left and cut in half again.
4. If the value that we are searching is bigger than the middle value then again we are going to search the right half.
5. if we find the value we are searching, then its index is returned or -1 is returned because we not found the value we are searching.
