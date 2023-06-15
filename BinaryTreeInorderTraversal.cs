public class Solution
{
    private readonly List<int> _nodes = new();

    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root is null)
        {
            return new List<int>();
        }

        GoDown(root);

        return _nodes;
    }

    private void GoDown(TreeNode node)
    {
        if (node.left is not null)
        {
            GoDown(node.left);
        }

        _nodes.Add(node.val);

        if (node.right is not null)
        {
            GoDown(node.right);
        }
    }
}