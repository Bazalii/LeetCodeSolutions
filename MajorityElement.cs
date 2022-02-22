public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        var dictionary = new Dictionary<int, int>();
        foreach (int elem in nums)
        {
            if (!dictionary.ContainsKey(elem))
                dictionary.Add(elem, 1);
            else
            {
                int value = dictionary[elem] + 1;
                dictionary.Remove(elem);
                dictionary.Add(elem, value);
            }
        }
        int mid = nums.Length / 2;
        foreach (KeyValuePair<int, int> kvp in dictionary)
        {
            if (kvp.Value > mid)
                return kvp.Key;
        }
        
        return -1;
    }
}