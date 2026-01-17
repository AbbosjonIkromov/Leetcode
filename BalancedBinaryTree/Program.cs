namespace BalancedBinaryTree;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        TreeNode root1 = new TreeNode(3,
            new TreeNode(9),
            new TreeNode(20,
                new TreeNode(15),
                new TreeNode(7)
            )
        );

        Test(solution, root1);

        TreeNode root2 = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(3,
                    new TreeNode(4),
                    new TreeNode(4)
                ),
                new TreeNode(3)
            ),
            new TreeNode(2)
        );

        Test(solution, root2);

    }
    static void Test(Solution solution,TreeNode root)
    {
        bool result = solution.IsBalanced(root);
        Console.WriteLine("Is Balanced: " + result);
    }
}


public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return CheckBalance(root) != -1;
    }
    private int CheckBalance(TreeNode node)
    {
        if (node == null)
            return 0;
        int leftHeight = CheckBalance(node.left);
        if (leftHeight == -1)
            return -1;
        int rightHeight = CheckBalance(node.right);
        if (rightHeight == -1)
            return -1;
        if (Math.Abs(leftHeight - rightHeight) > 1)
            return -1;
        return Math.Max(leftHeight, rightHeight) + 1;
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