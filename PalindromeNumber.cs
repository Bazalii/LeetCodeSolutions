public class Solution {
    public bool IsPalindrome(int x)
    {
        string input = Convert.ToString(x);
        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}