namespace BinaryGap;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 22); // output: [2]
        Test(solution, 8); // output: [0]
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.BinaryGap(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int BinaryGap(int n)
    {
        string binary = Convert.ToString(n, 2);

        int lastIndex = -1;
        int maxGap = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                if(lastIndex != -1)
                    maxGap = Math.Max(maxGap, i - lastIndex);

                lastIndex = i;
            }
        }

        return maxGap;
    }
}