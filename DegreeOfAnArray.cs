public class NumberInformation
{
    public int Degree { get; set; }
    public int StartIndex { get; set; }
    public int EndIndex { get; set; }
}

public class Solution
{
    public int FindShortestSubArray(int[] numbers)
    {
        var degrees = new Dictionary<int, NumberInformation>();

        for (var i = 0; i < numbers.Length; i++)
        {
            var number = numbers[i];

            if (degrees.TryGetValue(number, out var degree))
            {
                degree.Degree += 1;
                degree.EndIndex = i;
                continue;
            }

            degrees[number] = new NumberInformation
            {
                Degree = 1,
                StartIndex = i,
                EndIndex = i
            };
        }

        var maximumDegree = 0;
        var maximumDegrees = new List<NumberInformation>();

        foreach (var number in degrees.Keys)
        {
            if (degrees[number].Degree > maximumDegree)
            {
                maximumDegree = degrees[number].Degree;
                maximumDegrees = new List<NumberInformation> { degrees[number] };
            }
            else if (degrees[number].Degree == maximumDegree)
            {
                maximumDegrees.Add(degrees[number]);
            }
        }

        var minimumLength = numbers.Length;

        foreach (var degree in maximumDegrees)
        {
            var currentLength = degree.EndIndex - degree.StartIndex + 1;

            if (currentLength < minimumLength)
            {
                minimumLength = currentLength;
            }
        }

        return minimumLength;
    }
}