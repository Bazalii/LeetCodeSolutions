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
    public bool IsSymmetric(TreeNode root) 
    {
        if (root.left == null && root.right == null)
            return true;
        if (root.left == null || root.right == null)
            return false;
        return GoSymmetricDown(root.left, root.right);
    }
    
    public bool GoSymmetricDown(TreeNode left, TreeNode right)
    {
        bool firstTree = true;
        bool secondTree = true;
        if (left.val != right.val)
            return false;
        if (left.right != null && right.left != null)
            firstTree = GoSymmetricDown(left.right, right.left);
        if (left.left != null && right.right != null)
            secondTree = GoSymmetricDown(left.left, right.right);
        if (left.right == null && right.left != null ||
            left.left == null && right.right != null ||
            left.right != null && right.left == null ||
            left.left != null && right.right == null)
            return false;
        if (left.right == null && right.left == null && left.left == null && right.right == null || left.right == null && right.left == null && left.left.val == right.right.val || left.left == null && right.right == null && left.right.val == right.left.val)
            return firstTree && secondTree;
        return firstTree && secondTree;
    }
}