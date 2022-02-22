public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
        int[] result = new int [nums.Length];
        int minIndex = -1;
        int min = 10001;
        for (int i = 0; i < nums.Length; i++)
        {
            if (Math.Abs(nums[i]) < min)
            {
                min = Math.Abs(nums[i]);
                minIndex = i;
            }
        }
        Console.WriteLine(minIndex);
        int leftIterator = minIndex - 1;
        int rightIterator = minIndex + 1;
        int currentIterator = 1;
        result[0] = nums[minIndex] * nums[minIndex];
        while (leftIterator > -1 && rightIterator < nums.Length)
        {
            if (Math.Abs(nums[leftIterator]) < Math.Abs(nums[rightIterator]))
            {
                result[currentIterator] = nums[leftIterator] * nums[leftIterator];
                leftIterator--;
            }  
            else
            {
                result[currentIterator] = nums[rightIterator] * nums[rightIterator];
                rightIterator++;
            }
            currentIterator++;
        }
        while (leftIterator > -1)
        {
            result[currentIterator] = nums[leftIterator] * nums[leftIterator];
            leftIterator--;
            currentIterator++;
        }
        while (rightIterator < nums.Length)
        {
            result[currentIterator] = nums[rightIterator] * nums[rightIterator];
            rightIterator++;
            currentIterator++;
        }
        return result;
    }
}