public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {
        if (needle == "")
            return 0;
        if (needle.Length > haystack.Length)
            return -1;
        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            if (haystack[i] == needle[0])
            {
                int j;
                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;
                }
                
                if (j == needle.Length)
                    return i;
            }
        }
        
        return -1;
    }
}