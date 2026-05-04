namespace DayOfTheYear;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "2019-01-09"); // Output: [9]
        Test(solution, "2019-02-10"); // Output: [41]
    }

    static void Test(Solution solution, string date)
    {
        var result = solution.DayOfYear(date);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int DayOfYear(string date)
    {
        int year = int.Parse(date.Substring(0, 4));
        int month = int.Parse(date.Substring(5, 2));
        int day = int.Parse(date.Substring(8, 2));

        int[] daysInMonths = new int[] { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int dayOfYear = 0;

        for (int i = 0; i < month - 1; i++)
        {
            dayOfYear += daysInMonths[i];
        }

        dayOfYear += day;

        return dayOfYear;
    }

    // Kabisa yili aniqlash uchun yordamchi funksiya
    private bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
}