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
    public int GoodNodes(TreeNode root) {
        
        if(root == null)
            return 0;
        
        int count = 0;
        int max = Int32.MinValue;
        Traverse(root, max,ref count);

        return count;
    }

    public void Traverse(TreeNode curr,int max,ref int count)
    {
        if(curr == null)
            return;
        
        if(curr.val >= max) {
            count++;
            max = curr.val;
        }
        
        Traverse(curr.left,max,ref count);
        Traverse(curr.right,max,ref count);
    }
}