
var result = new Solution().CheckOnesSegment("1001");
Console.WriteLine(result);

public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        return !s.Contains("01");
    }
}