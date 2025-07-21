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
    public bool IsSymmetric(TreeNode root) {
        Queue<TreeNode> q = new();
        q.Enqueue(root.left);
        q.Enqueue(root.right);

        while(q.Count > 0)
        {
            var p1 = q.Dequeue();
            var p2 = q.Dequeue();

            if(p1 == null && p2 == null)
                continue;
            
            if(p1 == null || p2 == null)
                return false;
            
            if(p1.val!= p2.val)
                return false;
            
            q.Enqueue(p1.left);
            q.Enqueue(p2.right);
            q.Enqueue(p1.right);
            q.Enqueue(p2.left);
        }

        return true;
    }
}