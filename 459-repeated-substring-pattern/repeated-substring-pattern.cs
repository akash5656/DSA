public class Solution {
    public bool RepeatedSubstringPattern(string s) {

        int n = s.Length;
        
        for(int i=n/2;i>=1;i--)
        {
            if(n%i==0)
            {
                string sub = s.Substring(0,i);
                string repeated = string.Join("",Enumerable.Repeat(sub,n/i));
                if(repeated == s)
                return true;
            }

        }

        return false;

    }
}