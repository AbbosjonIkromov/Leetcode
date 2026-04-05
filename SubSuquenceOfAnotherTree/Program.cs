namespace SubSuquenceOfAnotherTree;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new TreeNode(3, new TreeNode(4, new TreeNode(1), new TreeNode(2)), new TreeNode(5)),
            new TreeNode(4, new TreeNode(1), new TreeNode(2))); // Output: [True]
    }

    static void Test(Solution solution, TreeNode root, TreeNode subRoot)
    {
        var result = solution.IsSubtree(root, subRoot);
        Console.WriteLine($"{result}");
    }
}



public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null) return false;

        if (IsSameTree(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot)
            || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;

        if (p.val != q.val) return false;

        return IsSameTree(p.left, q.left)
            && IsSameTree(p.right, q.right);
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