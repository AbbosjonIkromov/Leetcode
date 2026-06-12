namespace RemoveAllAdjacentDuplicatesInString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abbaca"); // Output: "ca"
        Test(solution, "azxxzy"); // Output: "ay"
    }

    static void Test(Solution solution, string s)
    {
        string result = solution.RemoveDuplicates(s);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string RemoveDuplicates(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (stack.Count > 0 && stack.Peek() == c)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return new string(stack.Reverse().ToArray());
    }
}
