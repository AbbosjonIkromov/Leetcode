namespace DefangingAnIPAddress;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "1.1.1.1"); // output: "1[.]1[.]1[.]1"
        Test(solution, "255.100.50.0"); // output: "255[.]100[.]50[.]0"
    }

    static void Test(Solution solution, string address)
    {
        var result = solution.DefangIPaddr(address);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string DefangIPaddr(string address)
    {
        return address.Replace(".", "[.]");
    }
}