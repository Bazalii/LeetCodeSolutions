public class Solution
{
    public int HammingWeight(uint number)
    {
        var numberOfOnes = 0;

        while (number != 0)
        {
            if (number % 2 == 1)
            {
                numberOfOnes++;
            }

            number /= 2;
        }

        return numberOfOnes;
    }
}