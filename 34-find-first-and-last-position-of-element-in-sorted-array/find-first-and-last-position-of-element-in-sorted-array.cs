public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
        int l = 0;
        int r = nums.Length - 1;

        int[] ans = Enumerable.Repeat(-1,2).ToArray();

        if(nums.Length==0)
            return ans;

        while(l<r)
        {
            int m = l + (r-l)/2;
            if(nums[m]< target)
            {
                l = m+1;
            }
            else
            {
                r = m;
            }
        }
        if(nums[l]==target)
            ans[0]=l;

        l = 0;
        r = nums.Length-1;

        while(l<r)
        {
            int m = l + (r-l+1)/2;
            if(nums[m]> target)
            {
                r = m-1;
            }
            else
            {
                l = m;
            }
        }
        if(nums[l]==target)
            ans[1]=l;

        return ans;

    }
}