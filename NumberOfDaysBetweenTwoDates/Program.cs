namespace NumberOfDaysBetweenTwoDates;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "2020-01-15", "2019-12-31"); // Output: 15
        Test(solution, "2020-01-01", "2020-01-31"); // Output: 30
    }

    static void Test(Solution solution, string date1, string date2)
    {
        int result = solution.DaysBetweenDates(date1, date2);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int DaysBetweenDates(string date1, string date2)
    {
        DateTime d1 = DateTime.Parse(date1);
        DateTime d2 = DateTime.Parse(date2);

        return Math.Abs((d1 - d2).Days);
    }
}
