public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int i = 0;
        int j = 0;

        Dictionary<char,int> map = new();

        int max = 0;

        for(j = 0; j < s.Length;j++)
        {
            if(map.ContainsKey(s[j]) && map[s[j]]>=i)
            {
                i = map[s[j]]+1;
            }
                map[s[j]] = j;
                int currWin = j-i+1;
                max = Math.Max(max,currWin);
        }

        return max;
        
    }
}