

Solution solution = new Solution();

Test(solution, "ab-cd"); // Output: "dc-ba"
Test(solution, "a-bC-dEf-ghIj"); // Output: "j-Ih-gfE-dCba"


static void Test(Solution solution, string s)
{
    var result = solution.ReverseOnlyLetters(s);
    Console.WriteLine($"[{result}]");
}

public class Solution
{
    public string ReverseOnlyLetters(string s)
    {
        char[] arr = s.ToCharArray();
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            if (!char.IsLetter(arr[left]))
            {
                left++;
            }
            else if (!char.IsLetter(arr[right]))
            {
                right--;
            }
            else
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        return new string(arr);
    }
}

