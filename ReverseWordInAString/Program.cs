namespace ReverseWordInAString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "Hello World"); // "World Hello"
        Test(solution, "Let's take LeetCode contest"); // "s'teL ekat edoCteeL tsetnoc"
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.ReverseWords(s);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            words[i] = new string(chars);
        }

        return string.Join(' ', words);
    }
}