public class Solution
{
    public int[] SortedSquares(int[] numbers)
    {
        var result = new int[numbers.Length];
        var resultPointer = 0;
        var rightPointer = 0;

        while (rightPointer < numbers.Length && numbers[rightPointer] < 0)
        {
            numbers[rightPointer] = -numbers[rightPointer];
            rightPointer++;
        }

        var leftPointer = rightPointer - 1;

        while (leftPointer > -1 && rightPointer < numbers.Length)
        {
            if (numbers[leftPointer] < numbers[rightPointer])
            {
                result[resultPointer] = numbers[leftPointer] * numbers[leftPointer];
                leftPointer--;
            }
            else
            {
                result[resultPointer] = numbers[rightPointer] * numbers[rightPointer];
                rightPointer++;
            }

            resultPointer++;
        }

        while (leftPointer > -1)
        {
            result[resultPointer] = numbers[leftPointer] * numbers[leftPointer];
            leftPointer--;
            resultPointer++;
        }

        while (rightPointer < numbers.Length)
        {
            result[resultPointer] = numbers[rightPointer] * numbers[rightPointer];
            rightPointer++;
            resultPointer++;
        }

        return result;
    }
}