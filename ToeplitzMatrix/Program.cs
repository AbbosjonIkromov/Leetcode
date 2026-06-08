namespace ToeplitzMatrix;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[][]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 1, 2, 3 },
            new int[] { 9, 5, 1, 2 }
        }); // Output: true

        Test(solution, new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 2, 2 }
        }); // Output: false
    }

    static void Test(Solution solution, int[][] matrix)
    {
        bool result = solution.IsToeplitzMatrix(matrix);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length - 1; i++)
        {
            for (int j = 0; j < matrix[i].Length - 1; j++)
            {
                if (matrix[i][j] != matrix[i + 1][j + 1])
                    return false;
            }
        }
        return true;
    }
}