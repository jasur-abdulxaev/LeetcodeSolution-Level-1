
var result = new Solution().SumOfUnique(new int[] { 1, 2, 3, 2 });
Console.WriteLine(result);

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        // Count frequency using array since nums[i] is between 1 and 100
        int[] freq = new int[101];
        foreach (int num in nums) freq[num]++;

        //Sum elements that appear exactly once
        int sum = 0;
        for (int i = 1; i <= 100; i++)
            if (freq[i] == 1) sum += i;

        return sum;
    }
}