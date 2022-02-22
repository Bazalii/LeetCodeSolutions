public class Solution 
{
    public bool IsHappy(int n) 
    {
        if (n == 1)
            return true;
        int prev = n;
        int iter = 0;
        while (true)
        {
            int next = 0, current = prev;
            while (current != 0)
            {
                int remainder = current % 10;
                next += remainder * remainder;
                current /= 10;
            }
            iter++;
            if (next == 1)
                return false;
            else if (iter > 20)
                return false;
            else
                prev = next;
        }
    }
}