public class Solution
{
    public int FindComplement(int number)
    {
        var factor = 1;
        var result = 0;

        while (number != 0)
        {
            if ((number & 1) == 0)
            {
                result += factor;
            }

            number >>= 1;
            factor <<= 1;
        }
        
        return result;
    }
}