namespace ConvertSortedArrayToBinarySearchTree;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        var nums = new int[] { -10, -3, 0, 5, 9 };

        Test(solution, nums); // [0,-3,9,-10,null,5]
    }
    static void Test(Solution solution, int[] nums)
    {
        var result = solution.SortedArrayToBST(nums);
        PrintTree(result);
    }
    static void PrintTree(TreeNode node)
    {
        if (node == null)
        {
            Console.Write("null ");
            return;
        }
        Console.Write($"{node.val} ");
        PrintTree(node.left);
        PrintTree(node.right);
    }
}



public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return BuildBST(nums, 0, nums.Length - 1);
    }
    private TreeNode BuildBST(int[] nums, int start, int end)
    {
        if(start > end)
            return null;
        int mid = (start + end) / 2;

        TreeNode node = new TreeNode(nums[mid]);

        node.left = BuildBST(nums, start, mid - 1);
        node.right = BuildBST(nums, mid + 1, end);

        return node;
    }
}


public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
