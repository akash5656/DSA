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
public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null)
            return 0;
            
        return maxDepth(root);
    }

    public int maxDepth(TreeNode curr)
    {
        if(curr == null)
            return 0;

        int leftMax = maxDepth(curr.left);
        int rightMax = maxDepth(curr.right);

        return Math.Max(leftMax,rightMax) + 1;
    }
}