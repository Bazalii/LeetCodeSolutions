public class Solution
{
    public int[] NumberOfLines(int[] widths, string word)
    {
        var numberOfLines = 1;
        var lastLineLength = 0;

        foreach (var letter in word)
        {
            var currentLetterWidth = widths[letter - 'a'];

            if (lastLineLength + currentLetterWidth <= 100)
            {
                lastLineLength += currentLetterWidth;
            }
            else
            {
                numberOfLines++;
                lastLineLength = currentLetterWidth;
            }
        }

        return new[] { numberOfLines, lastLineLength };
    }
}