public class Solution {
    public int FindLHS(int[] nums) {

        Dictionary<int,int> map = new();

        foreach(var n in nums)
        {
            if(!map.ContainsKey(n))
                map[n] = 0;
            
            map[n]++;
        }

        int ans = 0;

        foreach(var n in nums)
        {
            if(map.ContainsKey(n+1))
            {
                ans = Math.Max(ans,map[n]+map[n+1]);
            }
        }

        return ans;
        
    }
}