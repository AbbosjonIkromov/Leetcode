namespace ComplementOfBase10Integer;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, 5); // Output: 2
        Test(solution, 7); // Output: 0
    }

    static void Test(Solution solution, int n)
    {
        int result = solution.BitwiseComplement(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int BitwiseComplement(int n)
    {
        if (n == 0)
            return 1;

        string binary = Convert.ToString(n, 2);

        char[] chars = binary.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
            chars[i] = chars[i] == '0' ? '1' : '0';

        return Convert.ToInt32(new string(chars), 2);
    }
}