using System;

namespace DetermineWhetherMatrixCanBe;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        var mat = new int[][] {[1,0], [0,1] };

        var target = new int[][] {[1,0], [0,1]};

        Test(solution, mat, target); // Output: [True]
    }

    static void Test(Solution solution, int[][] mat, int[][] target)
    {
        var result = solution.FindRotation(mat, target);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool FindRotation(int[][] mat, int[][] target)
    {
        for (int k = 0; k < 4; k++)
        {
            if (IsEqual(mat, target))
                return true;

            mat = Rotate(mat);
        }

        return false;
    }

    private bool IsEqual(int[][] a, int[][] b)
    {
        int n = a.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i][j] != b[i][j])
                    return false;
            }
        }

        return true;
    }

    private int[][] Rotate(int[][] mat)
    {
        int n = mat.Length;
        int[][] res = new int[n][];

        for (int i = 0; i < n; i++)
            res[i] = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                res[j][n - 1 - i] = mat[i][j];
            }
        }

        return res;
    }
}
