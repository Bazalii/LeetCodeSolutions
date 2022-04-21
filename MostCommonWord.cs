public class Solution 
{
    public string MostCommonWord(string paragraph, string[] banned) 
    {
        var stats = new Dictionary<string, int>();
        var word = string.Empty;
        foreach (var letter in paragraph)
        {
            if (!char.IsLetter(letter))
            {
                if (word == string.Empty) continue;
                if (stats.ContainsKey(word))
                {
                    stats[word] += 1;
                }
                else
                {
                    stats[word] = 1;
                }

                word = string.Empty;
            }
            else
                word += letter.ToString().ToLower();
        }

        if (stats.ContainsKey(word))
        {
            stats[word] += 1;
        }
        else
        {
            stats[word] = 1;
        }

        stats = stats
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        return stats.Keys.FirstOrDefault(key => !Array.Exists(banned, currentWord => currentWord == key));
    }
}