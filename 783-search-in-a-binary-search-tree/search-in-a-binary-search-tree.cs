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

    TreeNode ans = null;

    public TreeNode SearchBST(TreeNode root, int val) {

        Search(root,val);

        return ans;

    }

    public void Search(TreeNode root,int val)
    {
        if(root == null)
             ans = null;
        
        if(root.val == val)
            ans = root;

        if(root.right!=null && root.val < val)
        {
            Search(root.right,val);
        }
        if(root.left!=null && root.val > val)
        {
            Search(root.left,val);
        }
    }
}