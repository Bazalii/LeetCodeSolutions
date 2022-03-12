public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length) return false;
        var magStats = new Dictionary<int, int>();
        foreach (var element in magazine)
        {
            if (!magStats.ContainsKey(element))
                magStats.Add(element, 0);
            magStats[element] += 1;
        }

        foreach (var element in ransomNote)
        {
            if (!magStats.ContainsKey(element) || magStats[element] == 0)
                return false;
            magStats[element] -= 1;
        }

        return true;
    }
}