public class Solution 
{
    public IList<int> GetRow(int rowIndex) 
    {
        if (rowIndex == 0) return new List<int> {1};
        if (rowIndex == 1) return new List<int> {1, 1};
        int[] previous = {1, 1};
        int[] current = {};
        for (int i = 2; i <= rowIndex; i++)
        {
            current = new int[i + 1];
            current[0] = 1;
            current[i] = 1;
            for (int j = 1; j < i; j++)
            {
                current[j] = previous[j - 1] + previous[j];
            }
            
            previous = current;
        }
        
        return current.ToList();
    }
}