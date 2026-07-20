using System.Text;

namespace ThousandSeparator;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 987); // Output: "987"
        Test(solution, 1234); // Output: "1.234"
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.ThousandSeparator(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string ThousandSeparator(int n)
    {
        string numStr = n.ToString();
        int length = numStr.Length;
        if (length <= 3)
        {
            return numStr;
        }
        StringBuilder sb = new StringBuilder();
        int count = 0;
        for (int i = length - 1; i >= 0; i--)
        {
            sb.Insert(0, numStr[i]);
            count++;
            if (count == 3 && i != 0)
            {
                sb.Insert(0, '.');
                count = 0;
            }
        }
        return sb.ToString();
    }
}