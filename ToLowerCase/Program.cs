namespace ToLowerCase;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, "Hello"); // output "hello"
        Test(solution, "here"); // output "here"
        Test(solution, "LOVELY"); // output "lovely"    
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.ToLowerCase(s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string ToLowerCase(string s)
    {
        var chars = s.ToCharArray();

        for(int i = 0; i < s.Length; i++)
        {
            if (chars[i] >= 'A' && chars[i] <= 'Z')
                chars[i] = (char)(chars[i] + 32);
        }

        return new string(chars);
    }
}
