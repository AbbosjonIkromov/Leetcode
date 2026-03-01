namespace BinaryTreePath;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        TreeNode root = new TreeNode(1,
            new TreeNode(2, null, new TreeNode(5)),
            new TreeNode(3));

        Test(solution, root); // Output: ["1->2->5", "1->3"]

    }

    static void Test(Solution solution, TreeNode root)
    {
        IList<string> paths = solution.BinaryTreePaths(root);
        Console.WriteLine($"[{string.Join(", ", paths)}]");
    }
}


public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> paths = new List<string>();
        if (root == null) return paths;

        DFS(root, "", paths);
        return paths;
    }

    private void DFS(TreeNode node, string path, List<string> result)
    {
        path += node.val.ToString();

        if (node.left == null && node.right == null)
        {
            result.Add(path);
            return;
        }

        path += "->";

        if (node.left != null)
            DFS(node.left, path, result);

        if (node.right != null)
            DFS(node.right, path, result);
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