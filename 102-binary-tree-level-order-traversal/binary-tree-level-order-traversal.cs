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
    public IList<IList<int>> LevelOrder(TreeNode root) {

        if(root == null)
            return [];
        
        List<IList<int>> ans = new();

        Queue<TreeNode> q = new();

        q.Enqueue(root);

        while(q.Count > 0)
        {
            List<int> l = new();
            int levelSize = q.Count;

            for(int i = 0; i < levelSize; i++)
            {
                var curr = q.Dequeue();
                l.Add(curr.val);
                if(curr.left != null)
                    q.Enqueue(curr.left);
                
                if(curr.right != null)
                    q.Enqueue(curr.right);
            }

            ans.Add(l);
        }

        return ans;

    }
}