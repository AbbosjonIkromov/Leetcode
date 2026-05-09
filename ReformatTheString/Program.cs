using System.Text;

namespace ReformatTheString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "a0b1c2"); // output: [a0b1c2]
        Test(solution, "leetcode"); // output: []
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.Reformat(s);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string Reformat(string s)
    {
        StringBuilder digits = new StringBuilder();
        StringBuilder letters = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsDigit(c))
                digits.Append(c);
            else
                letters.Append(c);
        }

        if (Math.Abs(digits.Length - letters.Length) > 1)
            return string.Empty;

        StringBuilder result = new StringBuilder();

        int i = 0, j = 0;

        bool digitTurn = digits.Length > letters.Length;

        while (i < digits.Length || j < letters.Length)
        {
            if (digitTurn)
            {
                if (i < digits.Length)
                    result.Append(digits[i++]);
            }
            else
            {
                if (j < letters.Length)
                    result.Append(letters[j++]);
            }

            digitTurn = !digitTurn;
        }

        return result.ToString();
    }
}