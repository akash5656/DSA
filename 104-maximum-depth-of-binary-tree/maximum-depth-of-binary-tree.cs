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
        int maxDepth = 0;

        if(root == null)
            return maxDepth;

        Traverse(root,1,ref maxDepth);

        return maxDepth;
    }

    public void Traverse(TreeNode curr,int level,ref int maxDepth)
    {
        if(curr == null)
            return;

        maxDepth = Math.Max(maxDepth,level);
        Traverse(curr.left,level+1,ref maxDepth);
        Traverse(curr.right,level+1,ref maxDepth);
    }
}