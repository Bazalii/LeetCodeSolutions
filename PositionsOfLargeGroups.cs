public class Solution
{
    public IList<IList<int>> LargeGroupPositions(string letters)
    {
        IList<IList<int>> result = new List<IList<int>>();

        var groupStart = 0;
        var groupEnd = 0;

        var currentLetter = letters[0];

        for (var i = 1; i < letters.Length; i++)
        {
            if (letters[i] == currentLetter)
            {
                groupEnd++;
                continue;
            }

            if (groupEnd - groupStart > 1)
            {
                result.Add(new List<int> { groupStart, groupEnd });
            }

            groupStart = i;
            groupEnd = groupStart;
            currentLetter = letters[i];
        }

        if (groupEnd - groupStart > 1)
        {
            result.Add(new List<int> { groupStart, groupEnd });
        }

        return result;
    }
}