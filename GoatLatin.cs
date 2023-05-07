public class Solution
{
    public string ToGoatLatin(string sentence)
    {
        var result = new StringBuilder();

        var indexOfCurrentSpace = 0;
        var indexOfNextSpace = sentence.IndexOf(' ');
        var wordCounter = 1;

        string currentWord;

        while (indexOfNextSpace != -1)
        {
            currentWord = sentence[indexOfCurrentSpace..indexOfNextSpace];

            result.Append(ChangeWord(currentWord, wordCounter));

            result.Append(' ');

            wordCounter++;
            indexOfCurrentSpace = indexOfNextSpace + 1;
            indexOfNextSpace = sentence.IndexOf(' ', indexOfNextSpace + 1);
        }

        currentWord = sentence[indexOfCurrentSpace..];

        result.Append(ChangeWord(currentWord, wordCounter));

        return result.ToString();
    }

    private string ChangeWord(string currentWord, int wordCounter)
    {
        var resultingWord = new StringBuilder();

        if (!IsVowel(currentWord[0]))
        {
            currentWord = currentWord[1..] + currentWord[0];
        }

        resultingWord.Append(currentWord + "ma");

        for (var i = 0; i < wordCounter; i++)
        {
            resultingWord.Append('a');
        }

        return resultingWord.ToString();
    }

    private bool IsVowel(char letter)
    {
        letter = char.ToLower(letter);

        return letter is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}