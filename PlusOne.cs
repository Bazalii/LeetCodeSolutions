public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        bool notNine = false;
        if (digits[0] == 9)
        {
            for (int i = digits.Length - 1; i > -1; i--)
            {
                if (digits[i] != 9)
                {
                    notNine = true;
                    break;
                }
            }
        }
        else
            notNine = true;
        if (notNine)
        {
            for (int i = digits.Length - 1; i > -1; i--)
            {
                int temp = digits[i] + 1;
                if (temp != 10)
                {
                    digits[i] = temp;
                    break;
                }
                digits[i] = 0;
            }
            
            return digits;
        }
        else 
        {
            int[] result = new int [digits.Length + 1];
            result[0] = 1;
            for (int i = 1; i < result.Length; i++)
                result[i] = 0;
            return result;
        }
        
        return new int[] { -1 };
    }
}