public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        var iterator1 = 0;
        var iterator2 = 0;
        var stats = new Dictionary<int, int>();
        var result = new List<int>();
        while (iterator1 < nums1.Length && iterator2 < nums2.Length)
        {
            var firstItem = nums1[iterator1];
            var secondItem = nums2[iterator2];
            if (firstItem < secondItem)
                iterator1++;
            else if (firstItem > secondItem)
                iterator2++;
            else
            {
                if (!stats.ContainsKey(firstItem))
                    stats[firstItem] = 0;
                stats[firstItem]++;
                iterator1++;
                iterator2++;
            }
        }

        foreach (var kvp in stats)
        {
            for (int i = 0; i < kvp.Value; i++)
                result.Add(kvp.Key);
        }

        return result.ToArray();
    }
}