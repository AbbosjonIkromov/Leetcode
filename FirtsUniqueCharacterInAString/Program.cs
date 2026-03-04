namespace FirtsUniqueCharacterInAString;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        Test(solution, "leetcode"); // output [0]
        Test(solution, "loveleetcode"); // output [2]
        Test(solution, "aabb"); // output [-1]
    }

    static void Test(Solution solution, string str)
    {
        var result = solution.FirstUniqChar(str);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if(dict[s[i]] == 1)
                return i;
        }
        
        return -1;
    }
}