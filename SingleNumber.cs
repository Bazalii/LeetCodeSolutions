public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        if (nums.Length == 1)
            return nums[0];
        Dictionary<int, int> countDict = new Dictionary<int, int>();
        foreach (int number in nums)
        {
            if (!countDict.ContainsKey(number))
                countDict.Add(number, 1);
            else
            {
                countDict.Remove(number);
            }
        }

        return countDict.Keys.First();
    }
}