public class Solution {
    public int NumSubseq(int[] nums, int target) {

        int n = nums.Length;

        int mod = 1_000_000_007;

        
        Array.Sort(nums);

        int[] pow = new int[n];
        pow[0] = 1;
        for(int i=1;i<n;i++)
        {
            pow[i]=(pow[i-1]*2) % mod;
        }

        int l =0;
        int r = n-1;

        int result = 0;

        while(l<=r)
        {
            if(nums[l]+nums[r]<=target)
            {
                result =  (result + (int)pow[r-l]) % mod;
                l++;
            }
            else
            {
                r--;
            }
        }

        return result;

    }
}