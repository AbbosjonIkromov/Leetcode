namespace BinaryTreeTilt;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new TreeNode(1, new TreeNode(2), new TreeNode(3))); // Output: 1
        Test(new Solution(), new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(5)), new TreeNode(9, null, new TreeNode(7)))); // Output: 15
    }

    static void Test(Solution solution, TreeNode root)
    {
        var result = solution.FindTilt(root);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    private int totalTilt = 0;
    public int FindTilt(TreeNode root)
    {
        CalculateTilt(root);
        return totalTilt;
    }
    private int CalculateTilt(TreeNode node)
    {
        if (node == null)
            return 0;

        int leftSum = CalculateTilt(node.left);
        int rightSum = CalculateTilt(node.right);

        int tilt = Math.Abs(leftSum - rightSum);
        totalTilt += tilt;

        return leftSum + rightSum + node.val;
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