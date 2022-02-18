/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) 
    {
        int bottom = 0;
        int top = n - 1;
        int index = n;
        while (bottom <= top)
        {
            long sum = (long)bottom + (long)top;
            int mid = (int) (sum / 2);
            if (IsBadVersion(mid))
            {
                top = mid - 1;
                index = mid;
            } 
            else    
                bottom = mid + 1;
        }
        
        return index;
    }
}