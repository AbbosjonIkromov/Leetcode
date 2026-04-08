namespace HeightChecker;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 1, 4, 2, 1, 3 }); // output: 3
        Test(solution, new int[] { 5, 1, 2, 3, 4 }); // output: 5
        Test(solution, new int[] { 1, 2, 3, 4, 5 }); // output: 0
    }

    static void Test(Solution solution, int[] heights)
    {
        var result = solution.HeightChecker(heights);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int HeightChecker(int[] heights)
    {
        var expected = (int[])heights.Clone();

        Array.Sort(expected);

        var countOfMismatches = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
                countOfMismatches++;
        }   

        return countOfMismatches;
    }
}