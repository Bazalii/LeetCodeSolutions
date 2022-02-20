public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int notZeroes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[notZeroes] = nums[i];
                notZeros++;
            }
        }
        
        for (int i = notZeroes; i < nums.Length; i++)
            nums[i] = 0;
    }
}