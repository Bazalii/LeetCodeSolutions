﻿public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0) return false;
        while (n > 1)
        {
            if (n % 2 != 0)
                return false;
            n /= 2;
        }

        return true;
    }
}