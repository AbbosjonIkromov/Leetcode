namespace CapitazileTitle;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, "capiTalIze tHe titLe"); // Output: "Capitalize the Title"
        Test(solution, "First leTTeR of EACH Word"); // Output: "First Letter of Each Word"
    }
    
    static void Test(Solution solution, string title)
    {
        string result = solution.CapitalizeTitle(title);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string CapitalizeTitle(string title)
    {
        string[] words = title.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 2)
            {
                words[i] = words[i].ToLower();
            }
            else
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }

        return string.Join(' ', words);
    }
}
