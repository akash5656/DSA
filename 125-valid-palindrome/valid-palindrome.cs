public class Solution {
    public bool IsPalindrome(string s) {
        
        s = s.Trim();

        if(s.Length == 0)
            return true;
        
        int first = 0;
        int last = s.Length-1;

        while(first < last)
        {
            if(char.IsLetterOrDigit(s[first]) && char.IsLetterOrDigit(s[last]))
            {
                if(char.ToLower(s[first]) != char.ToLower(s[last]))
                {
                    return false;
                }
                first+=1;
                last-=1;
            }
            if(!char.IsLetterOrDigit(s[first]))
            {
                first+=1;
            }
            if(!char.IsLetterOrDigit(s[last]))
            {
                last-=1;
            }
        }

        return true;

    }
}