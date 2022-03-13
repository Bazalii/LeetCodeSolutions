public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var result = new string[n];
        var iterator = 0;
        for (int i = 1; i <= n; i++)
        {
            var current = i.ToString();
            var firstCondition = i % 3 == 0;
            var secondCondition = i % 5 == 0;
            if (firstCondition && secondCondition)
                current = "FizzBuzz";
            else if (firstCondition)
                current = "Fizz";
            else if (secondCondition)
                current = "Buzz";
            result[iterator] = current;
            iterator++;
        }

        return result;
    }
}