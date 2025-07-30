/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {

        if(root == null)
            return null;
        
        Queue<Node> q = new();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            int level = q.Count;
            for(int i=0;i < level; i++)
            {
                var top = q.Dequeue();
                if(q.TryPeek(out Node newTop) && i!=level-1)
                {
                    top.next = newTop;
                }
                else
                {
                    top.next = null;
                }

                if(top.left != null)
                    q.Enqueue(top.left);
                if(top.right != null)
                    q.Enqueue(top.right);
            }

        }

        return root;

    }
}