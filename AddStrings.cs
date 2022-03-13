public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        var result = new List<char>();
        string lesser;
        string bigger;
        if (num1.Length < num2.Length)
        {
            lesser = num1;
            bigger = num2;
        }
        else
        {
            lesser = num2;
            bigger = num1;
        }

        int current = 0;
        for (int i = 1; i <= lesser.Length; i++)
        {
            var cur = bigger[^i] + lesser[^i] + current - '0' - '0';
            result.Add(Convert.ToChar((cur % 10 + '0')));
            current = cur / 10;
        }

        for (int i = lesser.Length + 1; i <= bigger.Length; i++)
        {
            var cur = bigger[^i] + current - '0';
            result.Add(Convert.ToChar((cur % 10 + '0')));
            current = cur / 10;
        }

        if (current != 0)
            result.Add(Convert.ToChar(current + '0'));

        var finalResult = result.ToArray();
        Array.Reverse(finalResult);
        return new string(finalResult);
    }
}