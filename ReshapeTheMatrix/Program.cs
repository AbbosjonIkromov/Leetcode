namespace ReshapeTheMatrix;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, new int[][] { new int[] {1, 2}, new int[] {3, 4} }, 1, 4); // output: [1, 2, 3, 4]

        Test(solution, new int[][] { new int[] {1, 2}, new int[] {3, 4} }, 2, 4); // output: [1, 2][3, 4]
    }

    static void Test(Solution solution, int[][] mat, int r, int c)
    {
        var result = solution.MatrixReshape(mat, r, c);

        PrintMatrix(result);
        Console.WriteLine();
    }

    static void PrintMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j]);

                if (j < matrix[i].Length - 1)
                    Console.Write(", ");
            }
            Console.Write("]");
        }
    }
}


public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int m = mat.Length;
        int n = mat[0].Length;

        if (m * n != r * c)
            return mat;

        int[][] result = new int[r][];
        for (int i = 0; i < r; i++)
        {
            result[i] = new int[c];
        }

        for (int i = 0; i < m * n; i++)
        {
            int oldRow = i / n;
            int oldCol = i % n;

            int newRow = i / c;
            int newCol = i % c;

            result[newRow][newCol] = mat[oldRow][oldCol];
        }

        return result;
    }
}