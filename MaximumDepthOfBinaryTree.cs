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
    public int MaxDepth(TreeNode root) 
    {
        if (root == null)
            return 0;
        return GoDown(0, root);
    }
    
    public int GoDown(int counter, TreeNode node)
    {
        int prevCounter = counter;
        if (node.left != null)
            counter = GoDown(counter, node.left);
        if (node.right != null)
            prevCounter = GoDown(prevCounter, node.right);
        if (counter == 0 && prevCounter == 0)
            return 1;
        else
            return counter > prevCounter ? counter + 1 : prevCounter + 1;
    }
}