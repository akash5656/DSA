public class Solution {
    public bool HasAllCodes(string s, int k) {

        int count = 1 << k;

        HashSet<string> map = new();

        for(int i = k; i <= s.Length; i++)
        {
            var str = s.Substring(i-k,k);
            if(!map.Contains(str))
            {
                map.Add(str);
                count--;
            }
            if(count == 0)
                return true;

        }
        return false;
        
    }
}