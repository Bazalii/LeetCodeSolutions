public class Solution
{
    private const string FirstRow = "qwertyuiop";
    private const string SecondRow = "asdfghjkl";
    private const string ThirdRow = "zxcvbnm";

    public string[] FindWords(string[] words)
    {
        var list = new List<string>();

        foreach (var word in words)
        {
            var lowercaseWord = word.ToLower();
            
            var firstRowIntersection = lowercaseWord.Any(letter => FirstRow.Contains(letter));
            var secondRowIntersection = lowercaseWord.Any(letter => SecondRow.Contains(letter));
            var thirdRowIntersection = lowercaseWord.Any(letter => ThirdRow.Contains(letter));

            if (firstRowIntersection && !secondRowIntersection && !thirdRowIntersection ||
                !firstRowIntersection && secondRowIntersection && !thirdRowIntersection ||
                !firstRowIntersection && !secondRowIntersection && thirdRowIntersection)
            {
                list.Add(word);
            }
        }

        return list.ToArray();
    }
}