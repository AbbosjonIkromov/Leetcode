namespace HammingDistance;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 1, 4); // output: [2]
        Test(solution, 3, 1); // output: [1]
    }

    static void Test(Solution solution, int x, int y)
    {
        var result = solution.HammingDistance(x, y);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int HammingDistance(int x, int y)
    {
        int distance = 0;
        int xor = x ^ y;
        while (xor != 0)
        {
            distance += xor & 1;
            xor >>= 1;
        }
        return distance;
    }
}