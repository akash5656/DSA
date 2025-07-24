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
    public int DiameterOfBinaryTree(TreeNode root) {
        int maxDia = 0;
        int height = FindDia(root,ref maxDia);
        return maxDia;
    }

    public int FindDia(TreeNode curr,ref int maxDia)
    {
        if(curr == null)
            return 0;

        var left = FindDia(curr.left,ref maxDia);
        var right = FindDia(curr.right,ref maxDia);

        maxDia = Math.Max(left+right,maxDia);

        return Math.Max(left,right)+1;
    }
}