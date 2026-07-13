namespace SelfDividingNumbers;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 1, 22); // Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
        Test(solution, 47, 85); // Output: [48, 55, 66, 77]
    }

    static void Test(Solution solution, int left, int right)
    {
        var result = solution.SelftDividingNumbers(left, right);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public IList<int> SelftDividingNumbers(int left, int right)
    {
        List<int> result = new List<int>();
        for (int i = left; i <= right; i++)
        {
            if (IsSelftDividing(i))
            {
                result.Add(i);
            }
        }

        return result;
    }

    private bool IsSelftDividing(int num)
    {
        for (int n = num; n > 0; n /= 10)
        {
            int digit = n % 10;
            if (digit == 0 || num % digit != 0)
            {
                return false;
            }
        }
        return true;
    }
}
