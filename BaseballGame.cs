public class Solution 
{
    public int CalPoints(string[] operations) 
    {
        var results = new Stack<int>();

        foreach (var operation in operations)
        {
            switch (operation) 
            {
                case "+":
                    results.Push(results.ElementAt(0) + results.ElementAt(1));
                    break;
                case "D":
                    results.Push(results.ElementAt(0) * 2);
                    break;
                case "C":
                    results.Pop();
                    break;
                default:
                    results.Push(int.Parse(operation));
                    break;
            }
        }

        return results.Sum();
    }
}