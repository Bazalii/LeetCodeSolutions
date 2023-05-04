public class Solution 
{
    public int HammingDistance(int x, int y) 
    {
        var distance = 0;

        if (x < y) 
        {
            var temporaryValue = y;
            y = x;
            x = temporaryValue;
        }

        while (y != 0) 
        {
            if (x % 2 != y % 2) 
            {
                distance++;
            }

            x /= 2;
            y /= 2;
        }

        while (x != 0) 
        {
            if (x % 2 != 0) 
            {
                distance++;
            }

            x /= 2;
        }

        return distance;
    }
}