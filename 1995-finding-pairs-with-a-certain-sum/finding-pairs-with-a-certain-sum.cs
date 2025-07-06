public class FindSumPairs {
    Dictionary<int,int> map = new();
    int[] nums1;
    int[] nums2;

    public FindSumPairs(int[] nums1, int[] nums2) {
        this.nums1 = nums1;
        this.nums2 = nums2;
        foreach(var n in nums2)
        {
            if(!map.ContainsKey(n))
                map[n]=0;
            map[n]++;
        }
    }
    
    public void Add(int index, int val) {
        int oldVal = this.nums2[index];
        if(map.ContainsKey(oldVal))
        {
            map[oldVal]--;
            if(map[oldVal]==0)
                map.Remove(oldVal);
        }
        
        this.nums2[index]+=val;
        int newVal = this.nums2[index];

        if(!map.ContainsKey(newVal))
            map[newVal] = 0;
        map[newVal]++;
    }
    
    public int Count(int tot) {
        int count = 0;
        foreach(var n in this.nums1)
        {
            if(map.ContainsKey(tot-n))
                count += map[tot-n];
        }

        return count;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */