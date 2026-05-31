namespace NextGreaterElementI;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 }); // output: [-1, 3, -1]
        Test(solution, new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 }); // output: [3, -1]
    }

    static void Test(Solution solution, int[] nums1, int[] nums2)
    {
        var result = solution.NextGreaterElement(nums1, nums2);
        Console.WriteLine($"Result: [{string.Join(", ", result)}]");
    }
}

    public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> nextGreaterMap = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();

            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                int current = nums2[i];

                while (stack.Count > 0 && stack.Peek() <= current)
                {
                    stack.Pop();
                }

                int greaterValue = stack.Count > 0 ? stack.Peek() : -1;
                nextGreaterMap.Add(current, greaterValue);

                stack.Push(current);
            }

            int[] ans = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                ans[i] = nextGreaterMap[nums1[i]];
            }

            return ans;
        }
    }