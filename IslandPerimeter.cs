public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        var perimeter = 0;
        var gridHeight = grid.Length;
        var gridLength = grid[0].Length;

        for (var y = 0; y < gridHeight; y++)
        {
            for (var x = 0; x < gridLength; x++)
            {
                if (grid[y][x] == 0)
                {
                    continue;
                }

                if (x - 1 == -1 || grid[y][x - 1] == 0)
                {
                    perimeter++;
                }

                if (x + 1 == gridLength || grid[y][x + 1] == 0)
                {
                    perimeter++;
                }

                if (y - 1 == -1 || grid[y - 1][x] == 0)
                {
                    perimeter++;
                }

                if (y + 1 == gridHeight || grid[y + 1][x] == 0)
                {
                    perimeter++;
                }
            }
        }

        return perimeter;
    }
}