
var result = new Solution().MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.",
    new string[] { "hit" });
Console.WriteLine(result);


public class Solution
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var bannedSet = new HashSet<string>(banned);
        var words = paragraph.ToLower().Split(new char[] { ' ', '!', '?', '\'', ',', ';', '.' },
            StringSplitOptions.RemoveEmptyEntries);

        var freq = new Dictionary<string, int>();
        string result = "";
        int maxCount = 0;

        foreach (var word in words)
        {
            if (bannedSet.Contains(word))
                continue;

            freq.TryGetValue(word, out int count);
            freq[word] = count + 1;

            if (count + 1 > maxCount)
            {
                maxCount = count + 1;
                result = word;
            }
        }
        return result;
    }
}