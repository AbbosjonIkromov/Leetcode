namespace TransposeMatrix;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        }); // Output: [[1,4,7],[2,5,8],[3,6,9]]
    }

    static void Test(Solution solution, int[][] matrix)
    {
        var result = solution.Transpose(matrix);
        foreach (var row in result)
        {
            Console.WriteLine($"[{string.Join(", ", row)}]");
        }
    }
}


public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                result[i][j] = matrix[j][i];
            }
        }
        return result;
    }
}