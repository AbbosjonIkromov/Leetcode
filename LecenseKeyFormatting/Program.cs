using System.Text;

namespace LecenseKeyFormatting;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "5F3Z-2e-9-w", 4); // Natija: "5F3Z-2E9W"
        Test(solution, "2-5g-3-J", 2); // Natija: "2-5G-3J"
    }

    static void Test(Solution solution, string s, int k)
    {
        var result = solution.LicenseKeyFormatting(s, k);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string LicenseKeyFormatting(string s, int k)
    {
        StringBuilder sb = new StringBuilder();

        int count = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '-')
                continue;

            if(count == k)
            {
                sb.Append('-');
                count = 0;
            }

            sb.Append(char.ToUpper(s[i]));
            count++;
        }

        char[] result = sb.ToString().ToCharArray();

        Array.Reverse(result);

        return new string(result);
    }
}