/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame 
{
    public int GuessNumber(int n) 
    {
        if (guess(n) == 0)
            return n;
        int bottom = 1;
        int top = n;
        while (bottom <= top)
        {
            int mid = bottom / 2 + top / 2 + 1;
            int result = guess(mid);
            if (result == 0)
                return mid;
            else if (result == -1)
                top = mid - 1;
            else 
                bottom = mid + 1;
        }
        
        return -1;
    }
}