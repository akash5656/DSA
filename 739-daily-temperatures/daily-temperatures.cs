public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int n = temperatures.Length;

        int[] ans = new int[n];
        Stack<int> stack = new();

        stack.Push(n-1);

        for(int i=n-2;i>=0;i--)
        {
            while(stack.Count > 0)
            {
                var top = stack.Peek();
                if(temperatures[i]>=temperatures[top])
                {
                    stack.Pop();
                }
                else
                {
                    ans[i] = top - i;
                    break;
                }
            }

            stack.Push(i);
        }

        return ans;

    }
}