public class Solution
{
    public string LicenseKeyFormatting(string key, int sectionLength)
    {
        var formattedKey = new StringBuilder();

        var currentSectionLength = 0;

        for (var i = 1; i <= key.Length; i++)
        {
            if (key[^i] != '-')
            {
                if (currentSectionLength != sectionLength)
                {
                    formattedKey.Append(char.ToUpper(key[^i]));
                    currentSectionLength++;
                }
                else
                {
                    formattedKey.Append('-');
                    formattedKey.Append(char.ToUpper(key[^i]));
                    currentSectionLength = 1;
                }
            }
        }

        return new string(formattedKey.ToString().Reverse().ToArray());
    }
}