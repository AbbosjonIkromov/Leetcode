using System.Text;

namespace UniqueMorseCodeWords;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new string[] { "gin", "zen", "gig", "msg" }); // Output: 2
        Test(solution, new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }); // Output: 26
    }

    static void Test(Solution solution, string[] words)
    {
        var result = solution.UniqueMorseRepresentations(words);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        var morseCodes = new string[] {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
            ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
            "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." 
        };

        HashSet<string> uniqueMorseCodes = new HashSet<string>();

        foreach (var word in words)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var ch in word)
            {
                sb.Append(morseCodes[ch - 'a']);
            }

            uniqueMorseCodes.Add(sb.ToString());
        }

        return uniqueMorseCodes.Count;
    }
}