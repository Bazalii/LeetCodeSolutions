public class Solution
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        var factor = (uint) Math.Pow(2, 31);

        while (n != 0)
        {
            var remainder = n % 2;

            result += remainder * factor;

            factor /= 2;
            n /= 2;
        }

        return result;
    }
}