public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        int wasLetter = -1;
        for (int i = s.Length - 1; i > -1; i--)
        {
            if (s[i] == ' ' && wasLetter != -1)
                return wasLetter - i;
            if (wasLetter == -1 && s[i] != ' ')
                wasLetter = i;
        }
        
        return wasLetter + 1;
    }
}