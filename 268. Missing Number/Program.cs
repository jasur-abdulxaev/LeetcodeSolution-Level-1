
var result = new Solution().MissingNumber(new[] { 3, 0, 1 });
Console.WriteLine(result);

// 1. Gauss formulasi — matematik yondashuv
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        long n = nums.Length;
        long expectedSum = n * (n + 1) / 2;
        long actualSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            actualSum += nums[i];
        }

        return (int)(expectedSum - actualSum);
    }
}

/*
// 2. XOR — bit manipulation yondashuv
public class XorSolution
{
    public int MissingNumber(int[] nums)
    {
        int result = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            result ^= i ^ nums[i];
        }

        return result;
    }
}
*/