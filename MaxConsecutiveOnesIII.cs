public class Solution
{
    public int LongestOnes(int[] numbers, int k)
    {
        var maximumLength = 0;
        var currentLength = 0;

        var rightPointer = 0;
        var leftPointer = 0;

        while (k > 0 && rightPointer < numbers.Length)
        {
            if (numbers[rightPointer] == 0)
            {
                k--;
            }

            maximumLength++;
            rightPointer++;
        }

        while (rightPointer < numbers.Length && numbers[rightPointer] != 0)
        {
            maximumLength++;
            rightPointer++;
        }

        currentLength = maximumLength;

        while (rightPointer < numbers.Length)
        {
            if (numbers[rightPointer] == 0)
            {
                while (numbers[leftPointer] != 0)
                {
                    leftPointer++;
                }

                leftPointer++;
            }

            rightPointer++;
            currentLength = rightPointer - leftPointer;

            if (currentLength > maximumLength)
            {
                maximumLength = currentLength;
            }
        }

        return maximumLength;
    }
}