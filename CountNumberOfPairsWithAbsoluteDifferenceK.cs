public class Solution 
{
    public int CountKDifference(int[] nums, int k) 
    {
        int arrayLength = nums.Length;
        for (int i = 1; i < arrayLength; i++)
        {
            int key = nums[i];
            int j = i - 1;
            while (j >= 0 && nums[j] > key)
            {
                nums[j + 1] = nums[j];
                j -= 1;
            }

            nums[j + 1] = key;
        }
        int pairsCounter = 0;
        for (int i = 0; i < arrayLength - 1; i++)
        {
            pairsCounter += 
                NumberCounter(nums, i, arrayLength, nums[i] + k);  
        }

        return pairsCounter;
    }

    public int NumberCounter(int[] array, int i, int arrayLength, int number)
    {
        int leftIndex = LeftBinarySearch(array, i, arrayLength, number);
        if (leftIndex == -1)
        {
            return 0;
        }
        int rightIndex = RightBinarySearch(array, i, arrayLength, number);

        return rightIndex - leftIndex + 1;
    }

    public int LeftBinarySearch(int[] array, int i, int arrayLength, int number)
    {
        int bottom = i + 1;
        int top = arrayLength - 1;
        int pairsCounter = 0;
        int index = -1;
        while (bottom <= top)
        {
            int mid = (bottom + top) / 2;
            if (array[mid] == number)
            {
                index = mid;
                top = mid - 1;
            }
            else if (array[mid] < number)
            {
                bottom = mid + 1;
            }
            else 
            {
                top = mid - 1;
            } 
        }

        return index;
    }

    public int RightBinarySearch(int[] array, int i, int arrayLength, int number)
    {
        int bottom = i + 1;
        int top = arrayLength - 1;
        int pairsCounter = 0;
        int index = -1;
        while (bottom <= top)
        {
            int mid = (bottom + top) / 2;
            if (array[mid] == number)
            {
                index = mid;
                bottom = mid + 1;
            }
            else if (array[mid] > number)
            {
                top = mid - 1;
            }
            else 
            {
                bottom = mid + 1;
            } 
        }

        return index;
    }
}