public class Solution 
{
    public int[] ShortestToChar(string s, char c) 
    {
        var wantedIndexes = new List<int>();
        var result = new List<int>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                wantedIndexes.Add(i);
            }
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            var closestDistance = s.Length;
            var currentDistance = s.Length;
            var iterator = 0;

            while (iterator < wantedIndexes.Count && currentDistance <= closestDistance)
            {
                closestDistance = currentDistance;
                currentDistance = Math.Abs(i - wantedIndexes[iterator]);
                iterator++; 
            }
            
            if (currentDistance < closestDistance) 
            {
                closestDistance = currentDistance;
            }
            
            result.Add(closestDistance);
        }
        
        return result.ToArray();
    }
}