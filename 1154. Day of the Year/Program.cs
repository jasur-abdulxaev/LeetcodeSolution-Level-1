
string test = "2020-12-31";

var res = new Solution();
Console.WriteLine(res.DayOfYear(test));


public class Solution
{
    public int DayOfYear(string date)
    {
        int year = int.Parse(date[..4]);
        int month = int.Parse(date[5..7]);
        int day = int.Parse(date[8..]);

        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            days[1] = 29;

        int result = 0;
        for (int i = 0; i < month - 1; i++)
            result += days[i];

        return result + day;
    }
}