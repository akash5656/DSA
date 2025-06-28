public class Solution {
    public bool CanConstruct(string s, int k) {
        
        int n = s.Length;
        if(n == k)
            return true;
        
        if(k > n)
            return false;
        
        Dictionary<char,int> map = new();

        foreach(var c in s)
        {
            if(!map.ContainsKey(c))
                map[c] = 0;

            map[c]++;
        }

        int count = map.Count(x => x.Value%2==1);

        if(count<=k)
            return true;
        
        return false;

    }
}