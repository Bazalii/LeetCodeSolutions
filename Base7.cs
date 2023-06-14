public class Solution
{
    public string ConvertToBase7(int number)
    {
        var result = 0;
        var degreeOfTen = 1;

        while (number != 0)
        {
            result += number % 7 * degreeOfTen;
            number /= 7;
            degreeOfTen *= 10;
        }

        return result.ToString();
    }
}