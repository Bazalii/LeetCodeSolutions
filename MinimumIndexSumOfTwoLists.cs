public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var result = new List<string>();
        var leastIndexSum = list1.Length + list2.Length;

        var firstList = list1.Select(element => element.GetHashCode()).ToList();
        var secondList = list2.Select(element => element.GetHashCode()).ToList();

        var firstListInformation = new Dictionary<int, (int, string)>();
        var secondListInformation = new Dictionary<int, (int, string)>();

        for (var i = 0; i < firstList.Count; i++)
        {
            firstListInformation[firstList[i]] = (i, list1[i]);
        }

        for (var i = 0; i < secondList.Count; i++)
        {
            secondListInformation[secondList[i]] = (i, list2[i]);
        }

        firstList.Sort();
        secondList.Sort();

        var firstPointer = 0;
        var secondPointer = 0;

        while (firstPointer < firstList.Count - 1 || secondPointer < secondList.Count - 1)
        {
            var firstElementHashCode = firstList[firstPointer];
            var secondElementHashCode = secondList[secondPointer];

            if (firstElementHashCode == secondElementHashCode)
            {
                var indexSum = firstListInformation[firstElementHashCode].Item1 +
                               secondListInformation[secondElementHashCode].Item1;

                if (indexSum < leastIndexSum)
                {
                    result.Clear();
                    result.Add(firstListInformation[firstElementHashCode].Item2);
                    leastIndexSum = indexSum;
                }
                else if (indexSum == leastIndexSum)
                {
                    result.Add(firstListInformation[firstElementHashCode].Item2);
                }
            }

            if (firstPointer == firstList.Count - 1)
            {
                secondPointer++;
                continue;
            }

            if (secondPointer == secondList.Count - 1)
            {
                firstPointer++;
                continue;
            }

            if (firstElementHashCode < secondElementHashCode)
            {
                firstPointer++;
            }
            else if (firstElementHashCode > secondElementHashCode)
            {
                secondPointer++;
            }
            else
            {
                firstPointer++;
                secondPointer++;
            }
        }

        var firstElement = firstList[^1];
        var secondElement = secondList[^1];

        if (firstElement != secondElement) return result.ToArray();
        
        var lastIndexSum = firstListInformation[firstElement].Item1 +
                           secondListInformation[secondElement].Item1;

        if (lastIndexSum < leastIndexSum)
        {
            result.Clear();
            result.Add(firstListInformation[firstElement].Item2);
        }
        else if (lastIndexSum == leastIndexSum)
        {
            if (!result.Contains(firstListInformation[firstElement].Item2))
            {
                result.Add(firstListInformation[firstElement].Item2);
            }
        }

        return result.ToArray();
    }
}