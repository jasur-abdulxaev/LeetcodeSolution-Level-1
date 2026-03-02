var num = 28;
var misol1 = new Solution();
Console.WriteLine(misol1.CheckPerfectNumber(num));


public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        if (num <= 1) return false;
        int sum = 1;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
                if (i != num / i)
                    sum += num / i;
            }
        }
        return sum == num;
    }
}