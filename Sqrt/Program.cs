namespace Sqrt;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();
        Test(solution, 4);    // output: [2]
        Test(solution, 8);    // output: [2]
        Test(solution, 2147395600); // output [46340]
        Test(solution, 3); // output [1]

    }
    static void Test(Solution solution, int x)
    {
        var result = solution.MySqrt(x);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int MySqrt(int x)
    {
        if(x == 0) return 0;
        else if (x < 4) return 1;

        int left = 2, right = x / 2, ans = 0;
        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            if (mid <= x / mid)
            {
                ans = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return ans;
    }
}
