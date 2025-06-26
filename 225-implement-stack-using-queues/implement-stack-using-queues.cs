public class MyStack {

    private Queue q1;
    private Queue q2;

    public MyStack() {
        
        q1 = new();
        q2 = new();

    }
    
    public void Push(int x) {
        q1.Enqueue(x);
    }
    
    public int Pop() {
        int n = q1.Count;
        for(int i =0;i<n-1;i++)
        {
            q2.Enqueue((int)q1.Dequeue());
        }

        var ans = (int)q1.Dequeue();

        var temp = q1;
        q1 = q2;
        q2 = temp;

        return ans;
    }
    
    public int Top() {
        int n = q1.Count;
        for(int i =0;i<n-1;i++)
        {
            q2.Enqueue((int)q1.Dequeue());
        }

        var top = (int)q1.Dequeue();
        q2.Enqueue(top);

        var temp = q1;
        q1 = q2;
        q2 = temp;

        return top;
    }
    
    public bool Empty() {
        return q1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */