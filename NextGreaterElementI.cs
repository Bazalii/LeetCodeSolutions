public class Solution
{
    public int[] NextGreaterElement(int[] subset, int[] array)
    {
        var arrayDictionary = new Dictionary<int, int>(array.Length);

        for (var i = 0; i < array.Length; i++)
        {
            arrayDictionary.Add(array[i], i);
        }

        for (var i = 0; i < subset.Length; i++)
        {
            var elementToSearch = subset[i];
            subset[i] = -1;
            
            for (var j = arrayDictionary[elementToSearch] + 1; j < array.Length; j++)
            {
                if (array[j] > elementToSearch)
                {
                    subset[i] = array[j];
                    break;
                }
            }
        }

        return subset;
    }
}