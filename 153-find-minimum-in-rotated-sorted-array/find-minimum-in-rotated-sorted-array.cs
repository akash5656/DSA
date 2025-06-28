public class Solution {
    public int FindMin(int[] nums) {

        int l = 0;
        int r = nums.Length-1;

        if(nums[l]<=nums[r])
            return nums[l];

        while(l <= r)
        {
            int mid = l + (r-l)/2;
            if(nums[l]<=nums[r])
                return nums[l];

            if(mid >= 1 && nums[mid]<nums[mid-1])
            {
                return nums[mid];
            }

            if(nums[mid] < nums[l])
            {
                r = mid-1;
            }
            else
            {
                l = mid+1;
            }
        }
        return -1;
        
    }
}