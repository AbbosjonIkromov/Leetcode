using System.Text;

namespace RemoveOutermostParentheses;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "(()())(())"); // output: "()()()"
        Test(solution, "(()())(())(()(()))"); // output: "()()()()(())"
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.RemoveOuterParentheses(s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string RemoveOuterParentheses(string s)
    {
        int depth = 0;
        StringBuilder result = new StringBuilder();

        foreach (char c in s)
        {
            if (c == '(')
            {
                if (depth > 0)
                    result.Append(c);

                depth++;
            }
            else
            {
                depth--;
                if (depth > 0)
                    result.Append(c);
            }
        }

        return result.ToString();
    }
}
