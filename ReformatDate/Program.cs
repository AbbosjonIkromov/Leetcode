
namespace ReformatDate;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        Test(solution, "20th Oct 2052"); // Output: [2052-10-20]
        Test(solution, "6th Jun 1933"); // Output: [1933-06-06]
    }

    static void Test(Solution solution, string date)
    {
        string result = solution.ReformatDate(date);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string ReformatDate(string date)
    {
        string[] parts = date.Split(' ');
        string day = parts[0].Replace("st", "").Replace("nd", "").Replace("rd", "").Replace("th", "");
        string month = GetMonthNumber(parts[1]);
        string year = parts[2];

        return FormatDate(day, month, year);
    }

    private string FormatDate(string day, string month, string year)
    {
        return $"{year}-{month}-{day.PadLeft(2, '0')}";
    }

    private string GetMonthNumber(string monthAsString)
    {
        switch (monthAsString)
        {
            case "Jan": return "01";
            case "Feb": return "02";
            case "Mar": return "03";
            case "Apr": return "04";
            case "May": return "05";
            case "Jun": return "06";
            case "Jul": return "07";
            case "Aug": return "08";
            case "Sep": return "09";
            case "Oct": return "10";
            case "Nov": return "11";
            case "Dec": return "12";
            default: throw new ArgumentException("Invalid month");
        }
    }
}