namespace DayOfTheWeek;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Test(solution, 31, 8, 2019); // output: "Saturday"
        Test(solution, 18, 7, 1999); // output: "Sunday"
    }

    static void Test(Solution solution, int day, int month, int year)
    {
        var result = solution.DayOfTheWeek(day, month, year);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string DayOfTheWeek(int day, int month, int year)
    {
        var date = new DateTime(year, month, day);
        return date.DayOfWeek.ToString();
    }
}