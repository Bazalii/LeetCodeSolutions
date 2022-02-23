public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int bottom = 0;
        int top = nums.Length - 1;
        int mid = 0;
        while (bottom <= top)
        {
            mid = (bottom + top) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[mid] > target)
                top = mid - 1;
            else
                bottom = mid + 1;
        }

        if (nums[mid] < target)
            return mid + 1;
        return mid;
    }
}