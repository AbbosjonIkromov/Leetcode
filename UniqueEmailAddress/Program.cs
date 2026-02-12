namespace UniqueEmailAddress;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        string[] emails1 = 
        { 
            "test.email+alex@leetcode.com",
            "test.e.mail+bob.cathy@leetcode.com",
            "testemail+david@lee.tcode.com" 
        };

        Test(solution, emails1); // Natija: 2

        string[] emails2 = 
        {
            "a@leetcode.com",
            "b@leetcode.com",
            "c@leetcode.com" 
        };

        Test(solution, emails2); // Natija: 3
    }

    static void Test(Solution solution, string[] emails)
    {
        int result = solution.NumUniqueEmails(emails);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> unique = new HashSet<string>();

        foreach (string email in emails)
        {
            string[] parts = email.Split(new char[] { '@' });
            string local = parts[0];
            string domain = parts[1];

            int plusIndex = local.IndexOf('+');
            if (plusIndex != -1)
            {
                local = local.Substring(0, plusIndex);
            }

            local = local.Replace(".", "");

            string normalizedEmail = local + "@" + domain;
            unique.Add(normalizedEmail);
        }
        return unique.Count;
    }
}
