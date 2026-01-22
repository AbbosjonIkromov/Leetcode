namespace MinimumPairRemovalToSortArray;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Test(solution, new int[] { 4, 3, 2, 1 });
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.MinimumPairRemoval(nums);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int MinimumPairRemoval(int[] nums)
    {
        var list = nums.ToList();
        int ops = 0;

        while (!IsSorted(list))
        {
            int minSum = int.MaxValue;
            int idx = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                int sum = list[i] + list[i + 1];
                if (sum < minSum)
                {
                    minSum = sum;
                    idx = i;
                }
            }

            list[idx] = list[idx] + list[idx + 1];
            list.RemoveAt(idx + 1);
            ops++;
        }

        return ops;
    }

    private bool IsSorted(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
            if (list[i] < list[i - 1])
                return false;
        return true;
    }
}



