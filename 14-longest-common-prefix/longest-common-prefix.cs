public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if(strs.Length==0 || strs == null)
        return string.Empty;

        if(strs.Length==1)
        return strs[0];

        int x = 0;
        while(x < strs[0].Length)
        {
            for(int i =1;i<strs.Length;i++)
            {
                if(x >= strs[i].Length || strs[0][x]!=strs[i][x])
                {
                    return strs[0].Substring(0,x);
                }
            }
            ++x;
        }

        return strs[0];
        
    }
}