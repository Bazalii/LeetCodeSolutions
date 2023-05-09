public class Solution
{
    public bool ValidPalindrome(string input)
    {
        var leftPointer = 0;
        var rightPointer = input.Length - 1;

        while (leftPointer < rightPointer)
        {
            if (input[leftPointer] != input[rightPointer])
            {
                var firstCondition = input[leftPointer + 1] == input[rightPointer];
                var secondCondition = input[leftPointer] == input[rightPointer - 1];

                if (firstCondition && secondCondition)
                {
                    return checkIfSequenceIsPalindrome(input[(leftPointer + 1)..(rightPointer + 1)]) ||
                           checkIfSequenceIsPalindrome(input[leftPointer..rightPointer]);
                }

                if (firstCondition)
                {
                    return checkIfSequenceIsPalindrome(input[(leftPointer + 1)..(rightPointer + 1)]);
                }

                if (secondCondition)
                {
                    return checkIfSequenceIsPalindrome(input[leftPointer..rightPointer]);
                }

                return false;
            }

            leftPointer++;
            rightPointer--;
        }

        return true;
    }

    private bool checkIfSequenceIsPalindrome(string sequence)
    {
        var leftPointer = 0;
        var rightPointer = sequence.Length - 1;

        while (leftPointer < rightPointer)
        {
            if (sequence[leftPointer] != sequence[rightPointer])
            {
                return false;
            }

            leftPointer++;
            rightPointer--;
        }

        return true;
    }
}