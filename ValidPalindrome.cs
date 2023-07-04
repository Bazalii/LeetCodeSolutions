public class Solution
{
    public bool IsPalindrome(string inputString)
    {
        var leftPointer = 0;
        var rightPointer = inputString.Length - 1;

        while (leftPointer < rightPointer)
        {
            if (!char.IsLetterOrDigit(inputString[leftPointer]))
            {
                leftPointer++;
                continue;
            }

            if (!char.IsLetterOrDigit(inputString[rightPointer]))
            {
                rightPointer--;
                continue;
            }

            if (char.ToLower(inputString[leftPointer]) != char.ToLower(inputString[rightPointer]))
            {
                return false;
            }

            leftPointer++;
            rightPointer--;
        }

        return true;
    }
}