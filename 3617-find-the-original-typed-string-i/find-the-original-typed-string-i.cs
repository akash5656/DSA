public class Solution {
    public int PossibleStringCount(string word) {

        if(word.Length == 1)
            return 1;

        int ans = 1;
        
        for(int i=1;i<word.Length;i++)
        {
            if(word[i]==word[i-1])
                ans++;
        }

        return ans;

    }
}