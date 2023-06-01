public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        return stones.Count(jewels.Contains);
    }
}