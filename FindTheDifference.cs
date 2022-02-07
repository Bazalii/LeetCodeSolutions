public class Solution 
{
    public char FindTheDifference(string s, string t) 
    {
        string tCopy = t;
        for (int i = 0; i < t.Length; i++)
        {
            int j;
            for (j = 0; j < s.Length; j++)
            {
                if (t[i] == s[j])
                {
                    tCopy = tCopy.Substring(1);
                    s = s.Substring(0, j) + s.Substring(j + 1);
                    break;
                }

                if (j == s.Length - 1)
                    return tCopy[0];
            }
        }

        return tCopy[0];
    }
}