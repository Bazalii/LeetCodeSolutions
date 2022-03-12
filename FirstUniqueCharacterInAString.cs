public class Solution 
{
    public int FirstUniqChar(string s) 
    {
        var result = new Dictionary<char, int>();
        foreach (var letter in s)
        {
            if (!result.ContainsKey(letter))
                result.Add(letter, 1);
            else
                result[letter]++;
        }
            
        foreach (var kvp in result)
        {
            if (kvp.Value == 1)
                return s.IndexOf(kvp.Key);
        }
        
        return -1;
    }
}