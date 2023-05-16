public class Solution
{
    public int[][] MatrixReshape(int[][] matrix, int reshapedMatrixRowNumber, int reshapedMatrixColumnNumber)
    {
        var initialMatrixRowNumber = matrix.Length;
        var initialMatrixColumnNumber = matrix[0].Length;

        if (initialMatrixRowNumber * initialMatrixColumnNumber !=
            reshapedMatrixRowNumber * reshapedMatrixColumnNumber ||
            initialMatrixRowNumber == reshapedMatrixRowNumber &&
            initialMatrixColumnNumber == reshapedMatrixColumnNumber)
        {
            return matrix;
        }

        var reshapedMatrix = new int[reshapedMatrixRowNumber][];
        reshapedMatrix[0] = new int[reshapedMatrixColumnNumber];

        var currentRow = 0;
        var currentColumn = 0;

        foreach (var row in matrix)
        {
            foreach (var element in row)
            {
                reshapedMatrix[currentRow][currentColumn] = element;

                currentColumn++;

                if (currentColumn == reshapedMatrixColumnNumber)
                {
                    currentRow++;
                    currentColumn = 0;

                    if (currentRow != reshapedMatrixRowNumber)
                    {
                        reshapedMatrix[currentRow] = new int[reshapedMatrixColumnNumber];
                    }
                }
            }
        }

        return reshapedMatrix;
    }
}