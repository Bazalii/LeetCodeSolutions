public class Solution 
{
    public IList<string> SummaryRanges(int[] nums) 
    {
        if (nums.Length == 0)
            return new List<string>(){};
        List<string> result = new ();
        int left = nums[0];
        int current = left;
        int right = left;
        for (int i = 1; i <= nums.Length; i++)
        {
            if (i < nums.Length && nums[i] == current + 1)
            {
                right = nums[i];
                current = right;
            }
            else
            {
                if (right != left)
                    result.Add($"{left}->{right}");
                else
                    result.Add($"{left}");
                if (i < nums.Length)
                {
                    left = nums[i];
                    right = left;
                    current = left;
                }
            }
        }
        
        return result;
    }
}