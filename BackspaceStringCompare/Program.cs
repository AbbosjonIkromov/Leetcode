namespace BackspaceStringCompare;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "ab#c", "ad#c"); // Output: true
        Test(solution, "ab##", "c#d#"); // Output: true
    }

    static void Test(Solution solution, string s, string t)
    {
        var result = solution.BackspaceCompare(s, t);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        return Build(s) == Build(t);
    }

    private string Build(string str)
    {
        Stack<char> chars = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '#')
            {
                if (chars.Count > 0)
                {
                    chars.Pop();
                }
            }
            else 
            {
                chars.Push(str[i]);
            }
        }

        return new string(chars.Reverse().ToArray());
    }
}
