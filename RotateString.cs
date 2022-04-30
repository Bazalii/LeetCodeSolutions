public class Solution 
{
    public bool RotateString(string s, string goal) 
    {
        if (s.Length != goal.Length)
        {
            return false;
        }
        
        var currentString = new StringBuilder(s, s.Length);
        
        for (int i = 0; i < s.Length; i++) 
        {
            if (currentString.ToString() == goal)
            {
                return true;
            }
            
            currentString.Remove(0, 1);
            currentString.Append(s[i]);
        }
        
        return false;
    }
}