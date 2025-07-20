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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> res = new();
        Traverse(root,res);
        return res;
    }

    public void Traverse(TreeNode curr, List<int> result)
    {
        if(curr == null)
            return;
        
        Traverse(curr.left,result);
        result.Add(curr.val);
        Traverse(curr.right,result);
    }
}