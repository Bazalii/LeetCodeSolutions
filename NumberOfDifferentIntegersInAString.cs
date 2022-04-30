public class Solution 
{
    public int NumDifferentIntegers(string word) 
    {
        var differentNumbers = new Dictionary<string, int>();
        var currentNumber = new StringBuilder();
        
        foreach (var letter in word) 
        {
            if (!char.IsDigit(letter))
            {
                if (currentNumber.ToString() == string.Empty) continue;
            
                var number = RemoveZeroes(currentNumber);

                differentNumbers[number] = 1;

                currentNumber.Clear();
            }
            else 
            {
                currentNumber.Append(letter);
            }
        }
        
        if (currentNumber.ToString() != string.Empty &&
            !differentNumbers.ContainsKey(RemoveZeroes(currentNumber)))
        {
            return differentNumbers.Count + 1;
        }
        
        return differentNumbers.Count;
    }
    
    public string RemoveZeroes(StringBuilder stringBuilder)
    {
        while (stringBuilder.Length != 0 && stringBuilder[0] == '0')
        {
            stringBuilder.Remove(0, 1);
        }
        
        return stringBuilder.Length == 0 ? "0" : stringBuilder.ToString();
    }
}