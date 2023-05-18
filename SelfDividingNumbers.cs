public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var selfDividingNumbers = new List<int>();

        while (left <= right)
        {
            var currentNumber = left;

            while (currentNumber != 0)
            {
                var remainder = currentNumber % 10;

                if (remainder == 0)
                {
                    break;
                }

                if (left % (remainder) != 0)
                {
                    break;
                }

                currentNumber /= 10;
            }

            if (currentNumber == 0)
            {
                selfDividingNumbers.Add(left);
            }

            left++;
        }

        return selfDividingNumbers;
    }
}