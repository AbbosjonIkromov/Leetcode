namespace PascalTriangleII;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 3); // output [1, 3, 3, 1]
        Test(solution, 4); // output [1, 4, 6, 4, 1]
    }
    
    static void Test(Solution solution, int rowIndex)
    {
        var result = solution.GetRow(rowIndex);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var result = new List<int>() { 1 };

        for (int i = 1; i <= rowIndex; i++)
        {
            result.Add(1);
            for (int j = i - 1; j > 0; j--)
            {
                result[j] = result[j] + result[j - 1];
            }
        }

        return result;
    }
}
