namespace ReverseVowelsOfAString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "IceCreAm"); // output [AceCreIm]
        Test(solution, "leetcode"); // output [leotcede]
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.ReverseVowels(s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string ReverseVowels(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        char[] chars = s.ToCharArray();

        while (left < right)
        {
            if (IsVowel(chars[left]) && IsVowel(chars[right]))
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }
            else if (!IsVowel(chars[left]))
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new string(chars);
    }

    private bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) >= 0;
    }
}