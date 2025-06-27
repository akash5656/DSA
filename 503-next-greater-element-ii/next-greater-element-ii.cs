public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        
        int[] arr = new int[2*nums.Length];

        for(int i=0;i<2*nums.Length;i++)
        {
            arr[i]=nums[i%nums.Length];
        }

        int n = arr.Length;

        Stack<int> stack = new();
        int[] ans = Enumerable.Repeat(-1, nums.Length*2).ToArray();
        stack.Push(arr[n-1]);

        for(int i=n-2;i>=0;i--)
        {
            while(stack.Count > 0)
            {
                var top = stack.Peek();
                if(arr[i] >= top)
                {
                    stack.Pop();
                }
                else
                {
                    ans[i]=top;
                    break;
                }
            }
            stack.Push(arr[i]);
        }
        return ans[0..nums.Length];
    }
}