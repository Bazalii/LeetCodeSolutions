public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var oldNumbers = new int[numbers.Length];

        Array.Copy(numbers, oldNumbers, numbers.Length);
        Array.Sort(numbers);

        var leftPointer = 0;
        var rightPointer = numbers.Length - 1;

        while (leftPointer != rightPointer)
        {
            var currentSummary = numbers[leftPointer] + numbers[rightPointer];

            if (currentSummary > target)
            {
                rightPointer--;
            }
            else if (currentSummary < target)
            {
                leftPointer++;
            }
            else
            {
                var firstIndex = int.MinValue;
                var secondIndex = 0;

                for (var i = 0; i < numbers.Length; i++)
                {
                    if (oldNumbers[i] == numbers[leftPointer] && firstIndex == int.MinValue)
                    {
                        firstIndex = i;
                    }
                    else if (oldNumbers[i] == numbers[rightPointer])
                    {
                        secondIndex = i;
                    }
                }

                return new[] { firstIndex, secondIndex };
            }
        }

        return Array.Empty<int>();
    }
}