public class Solution 
{
    public bool IsIsomorphic(string s, string t) 
    {
        var firstDict = new Dictionary<char, char>();
        var secondDict = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (firstDict.ContainsKey(s[i]))
            {
                if (firstDict[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (secondDict.ContainsKey(t[i]))
                {
                    if (secondDict[t[i]] != s[i])
                    {
                        return false;
                    }
                }
                else 
                {
                    firstDict.Add(s[i], t[i]);
                    secondDict.Add(t[i], s[i]);
                }
            }
        }
        
        return true;
    }
}