public class Solution {
    public int FindLucky(int[] arr) {

        Dictionary<int,int> map = new();
        
        for(int i=0; i<arr.Length;i++)
        {
            if(!map.ContainsKey(arr[i]))
                map[arr[i]]=0;
            map[arr[i]]++;
        }

        int ans = -1;

        foreach(var k in map)
        {
            if(k.Key == k.Value)
                ans = Math.Max(ans,k.Key);
        }

        return ans;

    }
}