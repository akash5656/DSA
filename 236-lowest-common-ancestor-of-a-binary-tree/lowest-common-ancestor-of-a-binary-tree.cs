/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        if(root == null)
            return null;

        if(root == p || root == q)
            return root;

        var leftN = LowestCommonAncestor(root.left,p,q);
        var rightN = LowestCommonAncestor(root.right,p,q);

        if(leftN!= null && rightN!= null)
            return root;
        
        return leftN ?? rightN;
    }
}