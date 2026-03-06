
var result = new Solution().AddStrings("123", "456");
Console.WriteLine(result);

public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
        var result = new System.Text.StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int x = i >= 0 ? num1[i--] - '0' : 0;
            int y = j >= 0 ? num2[j--] - '0' : 0;

            int sum = x + y + carry;
            result.Append(sum % 10);
            carry = sum / 10;
        }

        return new string(result.ToString().Reverse().ToArray());
    }
}