namespace ValidBoomerang;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[][] { new int[] { 1, 1 }, new int[] { 2, 3 }, new int[] { 3, 2 } }); // output: true
        Test(solution, new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 3 } }); // output: false
    }

    static void Test(Solution solution, int[][] points)
    {
        var result = solution.IsBoomerang(points);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsBoomerang(int[][] points)
    {
        int x1 = points[0][0], y1 = points[0][1];
        int x2 = points[1][0], y2 = points[1][1];
        int x3 = points[2][0], y3 = points[2][1];

        return (x2 - x1) * (y3 - y1) != (y2 - y1) * (x3 - x1);
    }
}