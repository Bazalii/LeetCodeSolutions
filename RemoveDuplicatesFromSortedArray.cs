public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        if (nums.Length == 0)
            return 0;
        if (nums.Length == 1)
            return 1;
        int current = nums[0];
        int iterator = 1;
        int uniqueElements = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != current)
            {
                nums[iterator] = nums[i];
                current = nums[i];
                uniqueElements++; 
                iterator++;
            }
        }
        
        return uniqueElements;
    }
}