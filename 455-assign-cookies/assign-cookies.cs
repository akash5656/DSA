public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        
        int i = 0;
        int j = 0;

        Array.Sort(g);
        Array.Sort(s);

        while(i < g.Length && j < s.Length)
        {
            if(s[j]>=g[i])
            {
                ++i;
            }
            ++j;
        }

        return i;
    }
}