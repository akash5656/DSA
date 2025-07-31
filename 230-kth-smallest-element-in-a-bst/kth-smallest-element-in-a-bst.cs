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
    int ans = -1;
    public int KthSmallest(TreeNode root, int k) {
        Traverse( root, ref k);
        return ans;
    }

    public void Traverse(TreeNode curr,ref int k)
    {
        if(curr == null)
            return;

        Traverse(curr.left,ref k);
        k--;

        if(k == 0)
        {
            ans = curr.val;
            return;
        }
            

        Traverse(curr.right,ref k);
    }
}