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
    public bool IsBalanced(TreeNode root) {
        return CheckBalance(root).isBalanced;
    }

    public (bool isBalanced,int currentHeight) CheckBalance(TreeNode node)
    {
        if(node == null)
            return (true,0);

        var left = CheckBalance(node.left);
        var right = CheckBalance(node.right);

        bool currentBalance = left.isBalanced
                        && right.isBalanced
                        && Math.Abs(left.currentHeight - right.currentHeight) <= 1;

        int currHeight = Math.Max(left.currentHeight,right.currentHeight)+1;
        
        return (currentBalance,currHeight);
    }
}