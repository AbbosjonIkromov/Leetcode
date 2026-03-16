namespace NumberComplement;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 5); // Output: 2
        Test(solution, 1); // Output: 0
    }

    static void Test(Solution solution, int num)
    {
        var result = solution.FindComplement(num);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int FindComplement(int num)
    {
        var binaryLength = Convert.ToString(num, 2).Length;

        int mask = (1 << binaryLength) - 1;

        return num ^ mask;
    }
}

