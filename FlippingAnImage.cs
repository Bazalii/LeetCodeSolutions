public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        foreach (var row in image)
        {
            for (var column = 0; column < row.Length / 2; column++)
            {
                var tempValue = row[column];
                row[column] = row[^(1 + column)] == 1 ? 0 : 1;
                row[^(1 + column)] = tempValue == 1 ? 0 : 1;
            }
        }

        if (image.Length % 2 == 0)
        {
            return image;
        }

        foreach (var row in image)
        {
            row[row.Length / 2] = row[row.Length / 2] == 1 ? 0 : 1;
        }

        return image;
    }
}