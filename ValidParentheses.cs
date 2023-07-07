public class Solution
{
    public bool IsValid(string inputString)
    {
        if (inputString.Length % 2 != 0)
        {
            return false;
        }

        var stack = new Stack<char>();

        foreach (var letter in inputString)
        {
            if (letter is '(' or '{' or '[')
            {
                stack.Push(letter);
                continue;
            }

            if (stack.Count == 0)
            {
                return false;
            }

            var topValue = stack.Pop();

            if (letter is ')' && topValue is not '(' ||
                letter is '}' && topValue is not '{' ||
                letter is ']' && topValue is not '[')
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}