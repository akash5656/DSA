public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> s1 = new();


        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='(' || s[i]=='{' || s[i]=='[')
            {
                s1.Push(s[i]);
            }
            else
            {
                if(s1.Count > 0)
                {
                    if(s1.Peek()=='[' && s[i]==']'
                    || s1.Peek()=='(' && s[i]==')'
                    || s1.Peek()=='{' && s[i]=='}')
                    {
                        s1.Pop();
                    }
                    else
                    {
                        s1.Push(s[i]);
                    }
                }
                else
                {
                    s1.Push(s[i]);
                }
            }
        }

        return s1.Count == 0;

    }
}