public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int> {1});
        if (numRows == 1) return result;
        result.Add(new List<int>{1, 1});
        for (int i = 1; i < numRows - 1; i++)
        {
            int[] row = new int [i + 2];
            row[0] = 1;
            row[i + 1] = 1;
            for (int j = 1; j < i + 1; j++)
            {
                row[j] = result[i][j - 1] + result[i][j]; 
            }
            result.Add(row.ToList());
        }
        
        return result;
    }
}