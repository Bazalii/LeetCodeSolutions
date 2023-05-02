public class Solution 
{
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        var disappearedNumbers = new int[nums.Length];
        var pointer = 0;

        var numbers = nums.ToHashSet();

        for (var i = 1; i <= nums.Length; i++) 
        {
            if (!numbers.Contains(i)) 
            {
                disappearedNumbers[pointer] = i;
                pointer++;
            }
        }

        var actualResult = new int[pointer];

        for (int i = 0; i < pointer; i++) 
        {
            actualResult[i] = disappearedNumbers[i];
        }

        return actualResult;
    }
}