namespace ExcelSheetColumnTitle;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 1); // A
        Test(solution, 2); // B
        Test(solution, 27); // AB
        Test(solution, 701); // ZY
    }

    static void Test(Solution solution, int columnNumber)
    {
        var result = solution.ConvertToTitle(columnNumber);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var result = string.Empty;

        while(columnNumber > 0)
        {
            columnNumber--;

            int helper = columnNumber % 26;
            result = (char)('A' + helper) + result;
            columnNumber /= 26;
        }

        return result;
    }
}