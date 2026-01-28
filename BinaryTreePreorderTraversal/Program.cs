namespace BinaryTreePreorderTraversal;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        TreeNode root = new TreeNode(1);

        root.left = new TreeNode(2);
        root.right = new TreeNode(3);

        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        root.left.right.left = new TreeNode(6);
        root.left.right.right = new TreeNode(7);

        root.right.right = new TreeNode(8);
        root.right.right.left = new TreeNode(9);

        Test(solution, root); // output [1, 2, 4, 5, 6, 7, 3, 8, 9]
    }

    static void Test(Solution solution, TreeNode root)
    {
        var result = solution.PreorderTraversal(root);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}



public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        Traverse(root, result);
        return result;
    }

    private void Traverse(TreeNode node, List<int> result)
    {
        if (node == null)
            return;

        result.Add(node.val);

        Traverse(node.left, result);

        Traverse(node.right, result);
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
