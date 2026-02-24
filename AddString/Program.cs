namespace AddString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "11", "123"); // 134
        Test(solution, "456", "77"); // 533
    }

    static void Test(Solution solution, string num1, string num2)
    {
        var result = solution.AddStrings(num1, num2);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        int i = num1.Length - 1;
        int j = num2.Length - 1;

        int carry = 0;
        string result = "";

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = i >= 0 ? num1[i] - '0' : 0;
            int digit2 = j >= 0 ? num2[j] - '0' : 0;

            int sum = digit1 + digit2 + carry;

            result = (sum % 10) + result;
            carry = sum / 10;

            i--;
            j--;
        }

        return result;
    }
}
