public class Solution {
    public int StrStr(string haystack, string needle) {

        int n = haystack.Length;

        int m = needle.Length;

        int[] lps = new int[m];

        int i = 0;
        int j = 1;

        while(j < m)
        {
            if(needle[i]==needle[j])
            {
                lps[j]=i+1;
                ++i;
                ++j;
            }
            else if(i==0)
            {
                lps[j]=0;
                ++j;
            }
            else
            {
                i = lps[i-1];
            }
        }

        i = 0;
        j = 0;
        
        while(i < n)
        {
            if(haystack[i]==needle[j])
            {
                i++;
                j++;
            }
            else
            {
                if(j==0)
                    i++;
                else
                    j = lps[j-1];
            }

            if(j == m)
                return i-m;
        }

        return -1;
        
    }
}