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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        var s1 = Serialize(root);
        var s2 = Serialize(subRoot);

        return s1.Contains(s2);
    }

    public string Serialize(TreeNode curr)
    {
        StringBuilder sb  = new();

        Traverse(curr,sb);

        return sb.ToString();

    }

    public void Traverse(TreeNode curr,StringBuilder hash)
    {
        if(curr == null)
        {
            hash.Append("#-");
            return;
        }

        hash.Append("-" + curr.val + "-");

        Traverse(curr.left, hash);
        Traverse(curr.right,hash);
    }
}