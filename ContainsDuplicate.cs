public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        var dict = new Dictionary<int,int>();
        foreach (int element in nums)
        {
            if (dict.ContainsKey(element))
                return true;
            else
                dict.Add(element, 1);
        }
        
        return false;
    }
}