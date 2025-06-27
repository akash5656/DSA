public class Solution {
    public int EvalRPN(string[] tokens) {

        if(tokens.Length == 1)
        return int.Parse(tokens[0]);
        
        Stack<int> stack = new();

        int ans = 0;
        
        for(int i=0;i<tokens.Length;i++)
        {
            if(int.TryParse(tokens[i],out int num))
            {
                stack.Push(num);
            }
            else
            {
                int a = stack.Pop();
                int b = stack.Pop();
                int result = tokens[i] switch
                            {
                                "+" => b + a,
                                "-" => b - a,
                                "*" => b * a,
                                "/" => b/a
                            };
                ans = result;
                stack.Push(result);
            }
        }

        return ans;

    }
}