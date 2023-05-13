public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
        {
            return true;
        }

        if (flowerbed.Length == 1)
        {
            return flowerbed[0] == 0 && n == 1;
        }

        if (flowerbed[0] == 0 && flowerbed[1] == 0)
        {
            flowerbed[0] = 1;

            n -= 1;
        }

        for (var i = 1; i < flowerbed.Length - 1; i++)
        {
            if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
            {
                flowerbed[i] = 1;
                n -= 1;
            }

            if (n == 0)
            {
                return true;
            }
        }

        if (n != 0 && flowerbed[^2] == 0 && flowerbed[^1] == 0)
        {
            n -= 1;
        }

        return n == 0;
    }
}