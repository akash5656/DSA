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
    public IList<int> RightSideView(TreeNode root) {

        if(root == null)
            return [];
        
        List<int> ans = new();
        Queue<TreeNode> q = new();

        q.Enqueue(root);

        while(q.Count > 0)
        {
            int level = q.Count;
            for(int i = 0;i<level;i++)
            {
                var top = q.Dequeue();
                if(i==0)
                    ans.Add(top.val);
                if(top.right!=null)
                    q.Enqueue(top.right);
                if(top.left!=null)
                    q.Enqueue(top.left);
            }

        }

        return ans;

    }
}