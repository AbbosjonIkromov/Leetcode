namespace CountCompleteTreeNodes;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3))); // output: [5]
    }

    static void Test(Solution solution, TreeNode root)
    {
        var result = solution.CountNodes(root);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null)
            return 0;

        int leftHeight = GetHeight(root);
        int rightHeight = GetRightHeight(root);

        if (leftHeight == rightHeight)
        {
            return (1 << leftHeight) - 1;
        }

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }

    private int GetHeight(TreeNode node)
    {
        int height = 0;
        while (node != null)
        {
            height++;
            node = node.left;
        }
        return height;
    }

    private int GetRightHeight(TreeNode node)
    {
        int height = 0;
        while (node != null)
        {
            height++;
            node = node.right;
        }
        return height;
    }
}


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}