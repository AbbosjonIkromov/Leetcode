namespace BinaryNumberWithAlternatingBits;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 5); // True
        Test(solution, 7); // False;
        Test(solution, 11); // False;
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.HasAlternatingBits(n);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        int prevBit = n & 1;
        n >>= 1;
        while (n > 0)
        {
            int currentBit = n & 1;
            if (currentBit == prevBit)
            {
                return false;
            }
            prevBit = currentBit;
            n >>= 1;
        }
        return true;
    }
}
