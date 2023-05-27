public class Solution 
{
    public int SmallestRangeI(int[] nums, int k)
    {
        var minimumDifference = nums.Max() - nums.Min() - 2 * k;

        return minimumDifference < 0 ? 0 : minimumDifference;
    }
}