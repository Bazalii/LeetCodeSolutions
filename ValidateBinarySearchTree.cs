/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool IsValidBST(TreeNode node)
    {
        return CheckSubtree(node, long.MinValue, long.MaxValue);
    }

    private bool CheckSubtree(TreeNode node, long leftBound, long rightBound)
    {
        if (node is null)
        {
            return true;
        }

        return node.val > leftBound && node.val < rightBound &&
               CheckSubtree(node.left, leftBound, node.val) &&
               CheckSubtree(node.right, node.val, rightBound);
    }
}