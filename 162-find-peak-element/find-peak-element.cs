public class Solution {
    public int FindPeakElement(int[] nums) {
        
        int l =0;
        int r = nums.Length-1;

        while(l<r)
        {
            int mid = l + (r-l)/2;
            
            if(mid+1 <= nums.Length-1 && nums[mid+1] > nums[mid])
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return r;
    }
}