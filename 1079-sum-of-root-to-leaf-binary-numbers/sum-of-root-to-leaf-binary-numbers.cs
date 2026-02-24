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
    public int SumRootToLeaf(TreeNode root) {
    
        return Solve(root,0);


        int Solve(TreeNode current,int val)
        {
            if(current == null)
                return 0;

            val = (2*val) + (1*current.val);

            if(current.left == null && current.right == null)
                return val;

            return Solve(current.left,val) + Solve(current.right,val);
        }
        
    }
}