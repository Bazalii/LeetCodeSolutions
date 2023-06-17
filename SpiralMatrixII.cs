public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        var matrix = new int[n][];

        for (var i = 0; i < n; i++)
        {
            matrix[i] = new int[n];
        }

        var currentNumber = 1;
        var circleNumber = 1;
        var rowNumber = 0;
        var columnNumber = 0;

        for (columnNumber = 0; columnNumber < n; columnNumber++)
        {
            matrix[rowNumber][columnNumber] = currentNumber;
            currentNumber++;
        }

        columnNumber--;

        while (currentNumber <= n * n)
        {
            for (var i = 0; i < n - circleNumber; i++)
            {
                rowNumber++;
                matrix[rowNumber][columnNumber] = currentNumber;
                currentNumber++;
            }

            if (currentNumber > n * n)
            {
                return matrix;
            }

            for (var i = 0; i < n - circleNumber; i++)
            {
                columnNumber--;
                matrix[rowNumber][columnNumber] = currentNumber;
                currentNumber++;
            }

            if (currentNumber > n * n)
            {
                return matrix;
            }

            circleNumber++;

            for (var i = 0; i < n - circleNumber; i++)
            {
                rowNumber--;
                matrix[rowNumber][columnNumber] = currentNumber;
                currentNumber++;
            }

            if (currentNumber > n * n)
            {
                return matrix;
            }

            for (var i = 0; i < n - circleNumber; i++)
            {
                columnNumber++;
                matrix[rowNumber][columnNumber] = currentNumber;
                currentNumber++;
            }

            if (currentNumber > n * n)
            {
                return matrix;
            }

            circleNumber++;
        }

        return matrix;
    }
}