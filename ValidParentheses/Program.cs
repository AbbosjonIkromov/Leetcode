namespace ValidParentheses;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        Test(solution, "()"); // true
        Test(solution, "()[]{}"); // true
        Test(solution, "(]"); // false
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.IsValid(s);
        Console.WriteLine($"Test Case: {s}\nResult: {result}");
    }
}

public class Solution
{
    public bool IsValid(string s)
    {
        var bracketsMap = new Dictionary<char, char>
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']'
        };

        var stack = new Stack<char>();

        foreach(char c in s)
        {
            if(bracketsMap.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false;

                var lastOpened = stack.Pop();

                if (bracketsMap[lastOpened] != c)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
