public class Solution
{
    public bool IsAnagram(string initialString, string stringToCheck)
    {
        if (initialString.Length != stringToCheck.Length)
        {
            return false;
        }

        var letterCounters = new int [26];

        for (var i = 0; i < initialString.Length; i++)
        {
            letterCounters[initialString[i] - 'a']++;
            letterCounters[stringToCheck[i] - 'a']--;
        }

        return letterCounters.All(counter => counter == 0);
    }
}