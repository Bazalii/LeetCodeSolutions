public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (!Char.IsLetter(s[left]) && !Char.IsNumber(s[left]))
                left++;
            else if (!Char.IsLetter(s[right]) && !Char.IsNumber(s[right]))
                right--;
            else if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                return false;
            else
            {
                left++;
                right--;
            }
        }
        
        return true;
    }
}