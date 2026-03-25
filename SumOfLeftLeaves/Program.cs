namespace SumOfLeftLeaves;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))); // output: [24]
    }

    static void Test(Solution solution, TreeNode root)
    {
        var result = solution.SumOfLeftLeaves(root);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root == null)
            return 0;

        int sum = 0;
        if (root.left != null)
        {
            if (root.left.left == null && root.left.right == null)
            {
                sum += root.left.val;
            }
            else
            {
                sum += SumOfLeftLeaves(root.left);
            }
        }
        sum += SumOfLeftLeaves(root.right);

        return sum;
    }
}

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
