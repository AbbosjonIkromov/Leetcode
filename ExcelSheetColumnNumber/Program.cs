namespace ExcelSheetColumnNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "AB"); // Output: 28
        Test(solution, "ZY"); // Output: 701
    }

    static void Test(Solution solution, string columnTitle)
    {
        var result = solution.TitleToNumber(columnTitle);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int result = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            result *= 26;
            result += columnTitle[i] - 'A' + 1;
        }

        return result;
    }
}