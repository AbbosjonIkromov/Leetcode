namespace AddBinary;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Test(solution, "11", "1"); // Output: "100"
        Test(solution, "1010", "1011"); // Output: "10101"
    }
    static void Test(Solution solution, string a, string b)
    {
        var result = solution.AddBinary(a, b);
        Console.WriteLine($"\"{result}\"");
    }
}



public class Solution
{
    public string AddBinary(string a, string b)
    {
        var aLen = a.Length - 1;
        var bLen = b.Length - 1;
        var carry = 0;
        var result = "";

        while (aLen >= 0 || bLen >= 0 || carry == 1)
        {
            var sum = carry;
            if (aLen >= 0)
            {
                sum += a[aLen] - '0';
                aLen--;
            }
            if (bLen >= 0)
            {
                sum += b[bLen] - '0';
                bLen--;
            }

            result = (sum % 2) + result;
            carry = sum / 2;
        }
        return result;
    }
}

