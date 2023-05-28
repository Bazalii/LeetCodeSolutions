public class Solution
{
    public int[][] ImageSmoother(int[][] image)
    {
        var height = image.Length;
        var width = image[0].Length;

        var smoothedImage = new int[height][];

        for (var i = 0; i < height; i++)
        {
            smoothedImage[i] = new int[width];

            for (var j = 0; j < width; j++)
            {
                var smoothedPixel = 0;
                var validElements = 0;

                if (i - 1 > -1)
                {
                    if (j - 1 > -1)
                    {
                        smoothedPixel += image[i - 1][j - 1];
                        validElements++;
                    }

                    if (j + 1 < width)
                    {
                        smoothedPixel += image[i - 1][j + 1];
                        validElements++;
                    }

                    smoothedPixel += image[i - 1][j];
                    validElements++;
                }

                if (j - 1 > -1)
                {
                    smoothedPixel += image[i][j - 1];
                    validElements++;
                }

                if (j + 1 < width)
                {
                    smoothedPixel += image[i][j + 1];
                    validElements++;
                }

                smoothedPixel += image[i][j];
                validElements++;

                if (i + 1 < height)
                {
                    if (j - 1 > -1)
                    {
                        smoothedPixel += image[i + 1][j - 1];
                        validElements++;
                    }

                    if (j + 1 < width)
                    {
                        smoothedPixel += image[i + 1][j + 1];
                        validElements++;
                    }

                    smoothedPixel += image[i + 1][j];
                    validElements++;
                }

                smoothedImage[i][j] = smoothedPixel / validElements;
            }
        }

        return smoothedImage;
    }
}