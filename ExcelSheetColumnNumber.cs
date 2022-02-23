public class Solution 
{
    public int TitleToNumber(string columnTitle) 
    {
        int result = 0;
        int degree = 26;
        for (int i = columnTitle.Length - 1; i > -1; i--)
            result += (columnTitle[i] - 'A' + 1) * (int)Math.Pow(26, columnTitle.Length - i - 1);
        return result;
    }
}