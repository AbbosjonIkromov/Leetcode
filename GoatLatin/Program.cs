namespace GoatLatin;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "I speak Goat Latin"); // Output: "Imaa peaksmaaa oatGmaaaa atinLmaaaaa"
        Test(solution, "The quick brown fox jumped over the lazy dog"); // Output: "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa"
    }

    static void Test(Solution solution, string sentence)
    {
        var result = solution.ToGoatLatin(sentence);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string ToGoatLatin(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (IsVowel(words[i][0]))
            {
                words[i] += "ma";
            }
            else
            {
                words[i] = words[i].Substring(1) + words[i][0] + "ma";
            }
            words[i] += new string('a', i + 1);
        }
        return string.Join(" ", words);
    }
    bool IsVowel(char c)
    {
        char lower = char.ToLower(c);
        return lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u';
    }
}