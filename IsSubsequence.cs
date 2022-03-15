public class Solution 
{
    public bool IsSubsequence(string s, string t) 
    {
        if (s.Length == 0) return true;
        if (t.Length == 0) return false;
        var iterator = 0;
        foreach (var letter in t)
        {
            if (letter == s[iterator])
                iterator++;
            if (iterator == s.Length)
                return true;
        }
        
        return iterator == s.Length;
    }
}