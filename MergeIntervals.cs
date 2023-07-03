public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        Array.Sort(intervals, (firstElement, secondElement) =>
        {
            if (firstElement[0] < secondElement[0])
            {
                return -1;
            }

            return firstElement[0] > secondElement[0] ? 1 : 0;
        });
        
        var intervalStart = intervals[0][0];
        var intervalEnd = intervals[0][1];

        var result = new List<int[]>();

        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= intervalEnd && intervalEnd <= intervals[i][1]) 
            {
                intervalEnd = intervals[i][1];
                continue;
            }

            if (intervalStart <= intervals[i][0] && intervalEnd >= intervals[i][1]) 
            {
                continue;
            }

            result.Add(new int[] { intervalStart, intervalEnd });

            intervalStart = intervals[i][0];
            intervalEnd = intervals[i][1];
        }

        if (result.Count != 0 && result[^1][0] <= intervalStart && intervalEnd <= result[^1][1]) 
        {
            return result.ToArray();
        }

        result.Add(new int[] { intervalStart, intervalEnd });        

        return result.ToArray();
    }
}