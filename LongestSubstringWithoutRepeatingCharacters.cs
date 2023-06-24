public class Solution 
{
    public int LengthOfLongestSubstring(string inputString) 
    {
        var substringCharacters = new HashSet<char>();
        var longestSubstringLength = 0;
        var rightPointer = 0;
        var leftPointer = 0;

        while (rightPointer < inputString.Length)
        {
            while (substringCharacters.Contains(inputString[rightPointer]))
            {
                substringCharacters.Remove(inputString[leftPointer]);
                leftPointer++;
            }

            substringCharacters.Add(inputString[rightPointer]);

            if (substringCharacters.Count > longestSubstringLength)
            {
                longestSubstringLength = substringCharacters.Count;
            }

            rightPointer++;
        }
        

        return longestSubstringLength;
    }
}