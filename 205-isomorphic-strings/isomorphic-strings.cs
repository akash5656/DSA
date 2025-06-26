public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        if(s.Length != t.Length)
        return false;

        Dictionary<char,char> mapSToT = new();
        Dictionary<char,char> mapTToS = new();

        for(int i=0;i<s.Length;i++)
        {
            if(!mapSToT.ContainsKey(s[i]) && !mapTToS.ContainsKey(t[i]))
            {
                mapSToT.Add(s[i],t[i]);
                mapTToS.Add(t[i],s[i]);
            }
            else if(mapTToS.ContainsKey(t[i]) && mapTToS[t[i]] != s[i])
            {
                return false;
            }
            else if(mapSToT.ContainsKey(s[i]) && mapSToT[s[i]] != t[i])
            {
                return false;
            }
        }

        return true;
    }
}