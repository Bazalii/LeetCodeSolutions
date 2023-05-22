public class Solution
{
    public TreeNode InvertTree(TreeNode node)
    {
        if (node is null)
        {
            return null;
        }

        (node.left, node.right) = (node.right, node.left);

        InvertTree(node.left);
        InvertTree(node.right);

        return node;
    }
}