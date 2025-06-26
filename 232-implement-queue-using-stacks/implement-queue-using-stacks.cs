public class MyQueue {

    private Stack<int> s1;
    private Stack<int> s2;

    public MyQueue() {
        s1 = new();
        s2 = new();
    }
    
    public void Push(int x) {
        s1.Push(x);
    }
    
    public int Pop() {
        int n = s1.Count;
        for(int i =0;i<n-1;i++)
        {
            s2.Push(s1.Pop());
        }

        int ans = s1.Pop();

        for(int i =0;i<n-1;i++)
        {
            s1.Push(s2.Pop());
        }

        return ans;
    }
    
    public int Peek() {
        int n = s1.Count;
        for(int i =0;i<n-1;i++)
        {
            s2.Push(s1.Pop());
        }

        int ans = s1.Pop();

        s1.Push(ans);

        for(int i =0;i<n-1;i++)
        {
            s1.Push(s2.Pop());
        }

        return ans;
    }
    
    public bool Empty() {
        return s1.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */