namespace ReverseBits;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 43261596); // 964176192
        Test(solution, 2147483644); // 1073741822
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.ReverseBits(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int ReverseBits(int n)
    {
        var result = 0;

        for(int i = 0; i < 32; i++)
        {
            int bit = n & 1;
            result = (result << 1) | bit;
            n >>= 1;
        }

        return result;
    }
}