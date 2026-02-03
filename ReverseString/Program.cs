namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Test(solution, new char[] { 'h', 'e', 'l', 'l', 'o' }); // output ['o','l','l','e','h']
            Test(solution, new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }); // output ['h','a','n','n','a','H']
        }

        static void Test(Solution solution, char[] characters)
        {
            solution.ReverseString(characters);
            Console.WriteLine($"[{string.Join(",", characters)}]");
        }
    }
}

public class Solution
{
    public void ReverseString(char[] s)
    {
        int left = 0, right = s.Length - 1;

        while(left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }

    }
}
