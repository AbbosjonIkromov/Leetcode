namespace DetectCapital;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "USA"); // output true
        Test(solution, "FlaG"); // output false
        Test(solution, "leetcode"); // output true
    }

    static void Test(Solution solution, string word)
    {
        var result = solution.DetectCapitalUse(word);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (word.All(char.IsUpper) || word.All(char.IsLower))
            return true;

        return char.IsUpper(word[0]) && word.Skip(1).All(char.IsLower);
    }
}
