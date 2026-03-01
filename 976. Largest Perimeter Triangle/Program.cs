
int[] nums = { 1, 2, 3, 4, 5, 6 };

var res = new Solution();
var result = res.LargestPerimeter(nums);
Console.WriteLine(result);

public class Solution
{
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        for (int i = nums.Length - 1; i >= 2; i--)
            if (nums[i] < nums[i - 1] + nums[i - 2])
                return nums[i] + nums[i - 1] + nums[i - 2];
        return 0;
    }
}