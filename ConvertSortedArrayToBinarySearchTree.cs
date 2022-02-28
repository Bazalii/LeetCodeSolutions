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
    public TreeNode SortedArrayToBST(int[] nums) 
    {
        if (nums.Length == 1) return new TreeNode(nums[0]);
        return Insert(nums, 0, nums.Length - 1);
    }
    
    public TreeNode Insert(int[] nums, int start, int end)
    {
        if (start > end)
            return null;
        int mid = (start + end) / 2;
        TreeNode current = new TreeNode(nums[mid], new TreeNode(), new TreeNode());
        current.left = Insert(nums, start, mid - 1);
        current.right = Insert(nums, mid + 1, end);
        return current;
    }
}