namespace PathSum;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        TreeNode root = new TreeNode(5,
            new TreeNode(4,
                new TreeNode(11,
                    new TreeNode(7),
                    new TreeNode(2)
                ),
                null
            ),
            new TreeNode(8,
                new TreeNode(13),
                new TreeNode(4,
                    null,
                    new TreeNode(1)
                )
            )
        );

        Test(solution, root, 22);
    }

    static void Test(Solution solution, TreeNode root, int targetSum)
    {
        var result = solution.HasPathSum(root, targetSum);
        Console.WriteLine($"[{result}]");
    }
}



public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;

        if(root.left == null && root.right == null)
            return targetSum == root.val;

        var result = HasPathSum(root.left, targetSum -  root.val) 
                || HasPathSum(root.right, targetSum - root.val);

        return result;
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
