public class Solution
{
    public bool IsPowerOfFour(int currentNumber)
    {
        while (currentNumber > 1)
        {
            if (currentNumber % 4 != 0)
            {
                return false;
            }

            currentNumber /= 4;
        }

        if (currentNumber == 1)
        {
            return true;
        }

        return false;
    }
}