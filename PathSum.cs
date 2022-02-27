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
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        if (root == null) return false;
        return MakeSum(0, targetSum, root);
    }
    
    public bool MakeSum(int sum, int target, TreeNode node)
    {
        bool leftSum = false;
        bool rightSum = false;
        sum += node.val;
        if (node.left != null)
        {
            leftSum = MakeSum(sum, target, node.left);
        }
        if (node.right != null)
        {
            rightSum = MakeSum(sum, target, node.right);
        }
        return leftSum || rightSum || sum == target && node.left == null && node.right == null; 
    }
}