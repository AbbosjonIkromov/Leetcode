namespace ValidPerfectSquare;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 16); // Output: true
        Test(solution, 14); // Output: false
    }

    static void Test(Solution solution, int num)
    {
        var result = solution.IsPerfectSquare(num);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        long left = 1;
        long right = num;

        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            long square = mid * mid;

            if (square == num)
                return true;

            if (square < num)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }
}