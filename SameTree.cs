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
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null)
            return false;
        return GoDown(p, q);
    }
    
    public bool GoDown(TreeNode first, TreeNode second)
    {
        bool current = true;
        if (first.left != null && second.left != null)
            current = GoDown(first.left, second.left);
        else if (first.left != null || second.left != null)
            return false;
        if (current && (first.right != null && second.right != null))
            current = GoDown(first.right, second.right);
        else if (first.right != null || second.right != null)
            return false;
        if (first.val != second.val)
            return false;  
        return current;
    }
}