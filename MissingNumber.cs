public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        var correctSum = 0;
        var realSum = 0;
        for (int i = 1; i <= nums.Length; i++)
        {
            correctSum += i;
            realSum += nums[i - 1];
        }
        
        return correctSum - realSum;
    }
}