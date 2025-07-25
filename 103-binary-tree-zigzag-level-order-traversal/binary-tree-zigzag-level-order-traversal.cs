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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {

        if(root == null)
            return [];

        Queue<TreeNode> q = new();
        q.Enqueue(root);

        List<IList<int>> ans = new();
        bool leftToRight = true;

        while(q.Count > 0)
        {
            int level = q.Count;
            List<int> res = new();

            for(int i = 0; i<level;i++)
            {
                var top = q.Dequeue();

                if(leftToRight)
                    res.Add(top.val);
                else
                    res.Insert(0,top.val);

                if(top.left != null)
                    q.Enqueue(top.left);
                
                if(top.right != null)
                    q.Enqueue(top.right);
            }

            leftToRight = !leftToRight;

            ans.Add(res);
        }

        return ans;
        
    }
}