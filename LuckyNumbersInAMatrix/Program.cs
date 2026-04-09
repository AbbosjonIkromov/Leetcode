namespace LuckyNumbersInAMatrix;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Test(solution, new int[][] { new int[] { 3, 7, 8 }, new int[] { 9, 11, 13 }, new int[] { 15, 16, 17 } }); // output: [15]
    }

    static void Test(Solution solution, int[][] matrix)
    {
        var result = solution.LuckyNumbers(matrix);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var luckyNumbers = new List<int>();

        for (int i = 0; i < matrix.Length; i++)
        {
            var minInRow = matrix[i].Min();
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == minInRow)
                {
                    var maxInColumn = matrix.Max(row => row[j]);
                    if (minInRow == maxInColumn)
                        luckyNumbers.Add(minInRow);
                }
            }
        }
        return luckyNumbers;
    }
}