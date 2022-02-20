public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        int current = 0;
        char[] first;
        char[] second;
        
        if (a.Length > b.Length)
        {
            first = a.ToCharArray();
            second = b.ToCharArray();
        }
        else
        {
            first = b.ToCharArray();
            second = a.ToCharArray();
        }
        
        List<int> result = new ();
        int iterator = 1; 
        
        for (int i = second.Length - 1; i > - 1; i--)
        {
            int firstElement = first[first.Length - iterator] == '0' ? 0 : 1;
            int secondElement = second[i] == '0' ? 0 : 1;
            int sum = firstElement + secondElement + current;
            result.Add(sum % 2);
            iterator++;
            if (sum > 1)
                current = 1;
            else
                current = 0;
        }
        
        for (int i = first.Length - second.Length - 1; i > -1; i--)
        {
            int firstElement = first[i] == '0' ? 0 : 1;
            int sum = firstElement + current;
            result.Add(sum % 2);
            if (sum > 1)
                current = 1;
            else
                current = 0;
        }
        
        if (current != 0)
            result.Add(1);
        
        var resultArray = result.ToArray();
        Array.Reverse(resultArray);
        return string.Join("", resultArray);
    }
}