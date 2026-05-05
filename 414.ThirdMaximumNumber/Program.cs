
int[] nums = { 3, 2, 1, 3, 5, 6, 8 };
var misol1 = new Solution();

Console.WriteLine(misol1.ThirdMax(nums));

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int x in nums)
        {
            set.Add(x);
            if (set.Count > 3) set.Remove(set.Min());
        }
        if (set.Count < 3) return set.Max();
        return set.Min();
    }
}