namespace PascalTriangle;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 5);
    }

    static void Test(Solution solution, int numRows)
    {
        var result = solution.Generate(numRows);
        foreach (var row in result)
        {
            Console.WriteLine(string.Join(", ", row));
        }
    }
}

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var triangle = new List<IList<int>>();
        for(int row = 0; row < numRows; row++)
        {
            var newRow = new List<int>();
            for(int col = 0; col <= row; col++)
            {
                if(col == 0 || col == row)
                {
                    newRow.Add(1);
                }
                else
                {
                    int left = triangle[row - 1][col - 1];
                    int right = triangle[row - 1][col];
                    newRow.Add(left + right);
                }
            }
            triangle.Add(newRow);
        }
        return triangle;
    }
}
