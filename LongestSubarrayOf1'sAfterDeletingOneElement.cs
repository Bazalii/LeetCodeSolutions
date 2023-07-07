public class Solution 
{
    public int LongestSubarray(int[] numbers) 
    {
        var numberOfZeroes = 0;
        var rightPointer = 0;
        var leftPointer = 0;
        var longestSubarray = 0;

        while (rightPointer < numbers.Length)
        {
            if (numbers[rightPointer] == 0) 
            {
                numberOfZeroes++;
            }
            
            while (numberOfZeroes > 1)
            {
                if (numbers[leftPointer] == 0)
                {
                    numberOfZeroes--;
                }

                leftPointer++;
            }
            
            var currentSubarrayLength = rightPointer - leftPointer;

            if (currentSubarrayLength > longestSubarray)
            {
                longestSubarray = currentSubarrayLength;
            }

            rightPointer++;
        }

        return longestSubarray;
    }
}