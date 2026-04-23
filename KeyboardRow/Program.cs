namespace KeyboardRow;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new string[] { "Hello", "Alaska", "Dad", "Peace" }); // output: ["Alaska","Dad"]
        Test(solution, new string[] { "adsdf", "sfd" }); // output: ["adsdf","sfd"]
    }

    static void Test(Solution solution, string[] words)
    {
        var result = solution.FindWords(words);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public string[] FindWords(string[] words)
    {
        var keyboardDict = new Dictionary<char, int>()
        {
            // 1st row
            { 'q', 1 },
            { 'w', 1 },
            { 'e', 1 },
            { 'r', 1 },
            { 't', 1 },
            { 'y', 1 },
            { 'u', 1 },
            { 'i', 1 },
            { 'o', 1 },
            { 'p', 1 },

            // 2st row
            { 'a', 2 },
            { 's', 2 },
            { 'd', 2 },
            { 'f', 2 },
            { 'g', 2 },
            { 'h', 2 },
            { 'j', 2 },
            { 'k', 2 },
            { 'l', 2 },

            // 3st row
            { 'z', 3 },
            { 'x', 3 },
            { 'c', 3 },
            { 'v', 3 },
            { 'b', 3 },
            { 'n', 3 },
            { 'm', 3 }
        };

        var result = new List<string>();

        foreach (string word in words)
        {
            int targetRow = keyboardDict[char.ToLower(word[0])];
            bool isValid = true;

            foreach (char c in word)
            {
                if (keyboardDict[char.ToLower(c)] != targetRow)
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }
}