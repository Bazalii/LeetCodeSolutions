public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if (strs.Length == 1)
            return strs[0];
        string answer = "";
        for (int i = 0; i < strs.Length - 1; i++)
        {
            int length = strs[i].Length < strs[i + 1].Length ? strs[i].Length : strs[i + 1].Length;
            int j;
            for (j = 0; j < length; j++)
            {
                if (strs[i][j] != strs[i + 1][j])
                {
                    if (answer == "" || answer.Length > j)
                    {
                        answer = strs[i].Substring(0, j);
                    }

                    break;
                }
            }

            if (j == length)
            {
                if (answer == "" || answer.Length > j)
                {
                    answer = strs[i].Substring(0, length);
                }
            }
            if (answer == "")
                return answer;
        }
        return answer;
    }
}