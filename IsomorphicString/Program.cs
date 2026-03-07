namespace IsomorphicString;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        Test(solution, "f11", "b23"); // output: false;
        Test(solution, "egg", "add"); // output: true
    }

    static void Test(Solution solution, string s, string t)
    {
        var result = solution.IsIsomorphic(s, t);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, char> dictS = new Dictionary<char, char>();
        Dictionary<char, char> dictT = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (dictS.ContainsKey(c1))
            {
                if (dictS[c1] != c2)
                    return false;
            }
            else
            {
                dictS[c1] = c2;
            }

            if (dictT.ContainsKey(c2))
            {
                if (dictT[c2] != c1)
                    return false;
            }
            else
            {
                dictT[c2] = c1;
            }
        }

        return true;
    }
}