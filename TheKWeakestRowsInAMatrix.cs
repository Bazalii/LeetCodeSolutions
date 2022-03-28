public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var counter = 0;
        var column = 0;
        var result = new HashSet<int>();
        while (counter < k && column < mat[0].Length)
        {
            for (int i = 0; i < mat.Length; i++)
            {
                if (!result.Contains(i) && mat[i][column] == 0)
                {
                    result.Add(i);
                    counter++;
                }

                if (counter == k)
                {
                    break;
                }
            }

            column++;
        }

        if (counter < k)
        {
            for (int i = 0; i < mat.Length; i++)
            {
                if (!result.Contains(i))
                {
                    result.Add(i);
                    counter++;
                }

                if (counter == k)
                {
                    break;
                }
            }
        }

        return result.ToArray();
    }
}