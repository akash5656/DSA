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

    int max_sum;

    public int MaxPathSum(TreeNode root) {
        max_sum = int.MinValue;
        Solve(root);

        return max_sum;
    }

    public int Solve(TreeNode root)
    {
        if(root == null)
            return 0;

        int l = Solve(root.left);
        int r = Solve(root.right);

        int oneGood = Math.Max(l,r) + root.val;

        int onlyRootGood = root.val;

        int notGoingOnTop = l + r + root.val;

        max_sum = Math.Max(max_sum,Math.Max(oneGood,Math.Max(onlyRootGood,notGoingOnTop)));

        return Math.Max(onlyRootGood,oneGood);
    }
}