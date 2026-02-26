namespace RamsonNote;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "a", "b"); // output: [false]
        Test(solution, "aa", "ab"); // output: [false]
        Test(solution, "aa", "aab"); // output: [true]
    }

    static void Test(Solution solution, string ransomNote, string magazine)
    {
        var result = solution.CanConstruct(ransomNote, magazine);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var dictionary = new Dictionary<char, int>();

        foreach (var c in magazine)
        {
            if (dictionary.ContainsKey(c))
                dictionary[c]++;
            else dictionary[c] = 1;
        }

        foreach (var c in ransomNote)
        {
            if(!dictionary.ContainsKey(c) || dictionary[c] == 0)
                return false;
            else dictionary[c]--;
        }

        return true;
    }
}
