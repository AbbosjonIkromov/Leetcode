namespace ValidPalindrome;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

    }
}


public class Solution
{
    #region Legacy Code
    //public bool IsPalindrome(string s)
    //{
    //    int currentLength = s.Length;
    //    var helper = string.Empty;

    //    for(int i = 0; i < currentLength; i++)
    //    {
    //        if (char.IsLetterOrDigit(s[i]))
    //            helper += char.ToLower(s[i]);
    //    }

    //    currentLength = helper.Length;

    //    for (int i = 0, j = currentLength - 1; i < j; i++, j--)
    //    {
    //        if (helper[i] != helper[j])
    //            return false;
    //    }

    //    return true;
    //}
    #endregion

    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;

            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }
        return true;
    }
}
