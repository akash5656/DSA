public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        
        var pq = new PriorityQueue<(int val,int idx),int>();

        for(int i =0 ;i<nums.Length;i++)
        {
            pq.Enqueue((nums[i],i),nums[i]);

            if(pq.Count > k)
            pq.Dequeue();
        }

        var result = new List<(int val,int idx)>();
        while(pq.Count > 0)
        {
            result.Add(pq.Dequeue());
        }

        result.Sort((a,b) => a.idx.CompareTo(b.idx));
        return result.Select(x => x.val).ToArray();

    }
}