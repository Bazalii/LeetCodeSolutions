public class Solution 
{
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        var dict = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                foreach (int element in dict[nums[i]])
                {
                    if (i - element <= k)
                        return true;
                }
                dict[nums[i]].Add(i);
            }
            else
                dict.Add(nums[i], new List<int>(){i});
        }
        
        return false;
    }
}