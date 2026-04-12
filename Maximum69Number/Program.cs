namespace Maximum69Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Test(solution, 9669); // output 9969
        }

        static void Test(Solution solution, int num)
        {
            var result = solution.Maximum69Number(num);
            Console.WriteLine($"[{result}]");
        }
    }
}


public class Solution
{
    public int Maximum69Number(int num)
    {
        char[] digits = num.ToString().ToCharArray();
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == '6')
            {
                digits[i] = '9';
                break;
            }
        }

        return Convert.ToInt32(new string(digits));
    }
}