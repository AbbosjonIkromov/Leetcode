namespace BinaryTreeInorderTraversal;

public class Program
{
    static void Main(string[] args)
    {
        var root = new TreeNode(1);
        root.right = new TreeNode(2);
        root.right.left = new TreeNode(3);

        var solution = new Solution();
        var result = solution.InorderTraversal(root);

        Console.WriteLine(string.Join(", ", result)); // 1, 3, 2
    }
}


public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var current = root;

        while(current != null || stack.Count > 0)
        {
            while(current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            result.Add(current.val);

            current = current.right;
        }

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
