namespace MatrixCellsInDistanceOrder;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 1, 2, 0, 0); // Output: [[0, 0], [0, 1]]
        Test(solution, 2, 2, 0, 1); // Output: [[0, 1], [0, 0], [1, 1], [1, 0]]
    }

    static void Test(Solution solution, int rows, int cols, int rCenter, int cCenter)
    {
        int[][] result = solution.AllCellsDistOrder(rows, cols, rCenter, cCenter);
        Console.WriteLine($"[{string.Join(", ", result.Select(cell => $"[{string.Join(", ", cell)}]"))}]");
    }

}

public class Solution
{
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
    {
        List<int[]> result = new List<int[]>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result.Add(new int[] { i, j });
            }
        }

        var sortedResult = result
            .OrderBy(cell =>
                Math.Abs(cell[0] - rCenter) +
                Math.Abs(cell[1] - cCenter))
            .ToArray();

        return sortedResult;
    }
}