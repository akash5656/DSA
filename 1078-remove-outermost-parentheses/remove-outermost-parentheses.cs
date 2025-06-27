public class Solution {
    public string RemoveOuterParentheses(string s) {

        Stack<char> stack = new();

        StringBuilder sb = new();
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='(')
            {
                stack.Push(s[i]);
                if(stack.Count > 1)
                {
                    sb.Append(s[i]);
                }
            }
            else
            {
                if(stack.Count > 1)
                {
                    sb.Append(s[i]);
                }
                stack.Pop();
            }
        }

        return sb.ToString();
        
    }
}