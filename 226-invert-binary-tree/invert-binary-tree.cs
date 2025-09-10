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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)
            return null;
        Invert(root);
        return root;
    }
    public void Invert(TreeNode curr)
    {
        if(curr == null)
            return;
        
        var temp = curr.left;
        curr.left = curr.right;
        curr.right = temp;

        Invert(curr.left);
        Invert(curr.right);
    }
}