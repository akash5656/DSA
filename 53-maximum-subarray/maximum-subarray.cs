public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int res = nums[0];

        for(int i =1; i < nums.Length;i++) {
            max = Math.Max(nums[i],nums[i] + max);
            res = Math.Max(max,res);
        }

        return res;
    }
}