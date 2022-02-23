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
    public IList<int> InorderTraversal(TreeNode root) 
    {
        if (root == null)
            return new List<int>();
        if (root.left == null && root.right == null)
            return new List<int>(){ root.val };
        var result = new List<int>();
        var currentNode = root;
        result = GoDown(root, result);
        return result;
    }
    
    public List<int> GoDown(TreeNode node, List<int> list)
    {
        if (node.left != null)
            GoDown(node.left, list);
        list.Add(node.val);
        if (node.right != null)
            GoDown(node.right, list);
        return list;
    }
}