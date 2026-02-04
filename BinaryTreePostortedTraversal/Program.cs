namespace BinaryTreePostortedTraversal;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        TreeNode root = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)
            ),
            new TreeNode(3)
        );

        Test(solution, root); // output [4,5,2,3,1]
    }

    static void Test(Solution solution, TreeNode root)
    {
        var result = solution.PostorderTraversal(root);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        if (root == null) return result;

        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();

        stack1.Push(root);

        while (stack1.Count > 0)
        {
            var node = stack1.Pop();
            stack2.Push(node);

            if (node.left != null)
                stack1.Push(node.left);

            if (node.right != null)
                stack1.Push(node.right);
        }

        while (stack2.Count > 0)
        {
            result.Add(stack2.Pop().val);
        }

        return result;
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