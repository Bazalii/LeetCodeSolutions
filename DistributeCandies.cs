public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        var numberOfAllowedCandies = candyType.Length / 2;
        var candyTypesHashSet = new HashSet<int>();

        foreach (var type in candyType)
        {
            candyTypesHashSet.Add(type);
        }

        return candyTypesHashSet.Count < numberOfAllowedCandies ? candyTypesHashSet.Count : numberOfAllowedCandies;
    }
}